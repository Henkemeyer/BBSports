import React, { useContext, useEffect, useState } from 'react';
import { Alert, FlatList, Keyboard, KeyboardAvoidingView, Modal, Platform, ScrollView, StyleSheet,
    Text, TouchableOpacity, TouchableWithoutFeedback, View } from 'react-native';
import { Table, TableWrapper, Row, Cell } from 'react-native-table-component';
import { fetchAthleteGroup, fetchCardioLog, fetchRoster, postEvent } from '../util/http';
import { UserContext } from '../store/context/user-context';
import CheckBox from '../components/CheckBox';
import UserInput from '../components/UserInput';
import OurButton from '../components/OurButton';
import Colors from '../constants/ColorThemes';
import { Ionicons } from '@expo/vector-icons';

const CoachCardioScreen = ({ route, navigation }) => {
    const { eventId } = route.params;
    const userCtx = useContext(UserContext);      // App User Info
    const token = userCtx.token;                  // User Auth Token

    const [distance, setDist] = useState(0);        // Distance travelled during workout
    const [notes, setNotes] = useState('');     // Workout notes
    const [selAthletes, setSelAthletes] = useState([]);
    const [athletes, setAthletes] = useState([]);  // List of users for Roster
    const [testID, setTestID] = useState('');
    const [groups, setGroups] = useState([]);         // Group used for workout
    const [groupToggles, setGroupToggles] = useState({});

    const [modalLogsVisible, setModalLogsVisible] = useState(false);
    const [athleteLogs, setAthleteLogs] = useState([]);
    const [athleteObj, setAthletesObj] = useState([]);
    const [logAthletesName, setLogAthletesName] = useState('');

    const header = {
        tableHead: ['', 'Name', 'Groups', 'Year'],
        widthArr: [40, 200, 400, 60]
    }

    useEffect(() => {
        async function getAthletes() {
            const dbAthletes = await fetchRoster(userCtx.teamId, token);
            const rosterArr = [];
            let selAthArr = []
            let tmpGroups = []
            let tmpGrpToggle = {}

            for (const key in dbAthletes.data) {
                if(dbAthletes.data[key].status !== 'A') {
                    continue;
                }
                let groupStr = '';

                if(dbAthletes.data[key].groups) {
                    const abb = dbAthletes.data[key].groups
                    for (const group in abb) {
                        console.log(abb[group])
                        if(tmpGroups.indexOf(abb[group]) < 0) {
                            tmpGroups = [...tmpGroups, abb[group]];

                            const hold = {
                                selected: false,
                                name: abb[group],
                                athletes: [dbAthletes.data[key].uid]
                            }
                            tmpGrpToggle[abb[group]] = hold
                        } else {
                            tmpGrpToggle[abb[group]].athletes = [...tmpGrpToggle[abb[group]].athletes, dbAthletes.data[key].uid]
                        }
                    }
                    setGroupToggles(tmpGrpToggle)
                    setGroups(tmpGroups)

                    dbAthletes.data[key].groups.map((groupName, id) => (
                        groupStr += groupName+", "
                    ))
                    groupStr = groupStr.slice(0, -2)
                }
                selAthArr[dbAthletes.data[key].uid] = false;

                const athArr = [
                    <CheckBox toggle={() => toggleAthleteSelection(dbAthletes.data[key].uid)} />,
                    <TouchableOpacity onPress={() => showLogsHandler(dbAthletes.data[key].uid, dbAthletes.data[key].fullName)}>
                        <Text style={styles.clickableText}>{dbAthletes.data[key].fullName}</Text>
                    </TouchableOpacity>,
                    groupStr,
                    dbAthletes.data[key].age,
                ]
                rosterArr.push(athArr);
            }
            setSelAthletes(selAthArr)
            setAthletes(rosterArr);
        }
    
        getAthletes();
    }, [userCtx.teamId]);

    function showLogsHandler(athletesUid, athletesName) {
        async function getDBAthleteLogs() {
            const dbLogs = await fetchCardioLog(athletesUid, token);
            var listArr = [];
            const logData = [];

            for (const key in dbLogs.data) {
                const tmpObj = {
                    id: key,
                    title: dbLogs.data[key].date
                }
                listArr = [...listArr, tmpObj];

                const tmpData = {
                    notes: dbLogs.data[key].notes,
                    feel: dbLogs.data[key].feel,
                    distance: dbLogs.data[key].distance,
                    duration: dbLogs.data[key].duration,
                    date: dbLogs.data[key].date
                }
                logData[key] = tmpData;
            }

            const dateDescending = [...listArr].sort((a, b) =>
                a.title > b.title ? -1 : 1,
            );
            setAthletesObj(logData);
            setAthleteLogs(dateDescending);

            if(listArr.length===0) {
                Alert.alert("Athlete has no log data");
            } else {
                setLogAthletesName(athletesName);
                setModalLogsVisible(!modalLogsVisible)
            }
        }
    
        getDBAthleteLogs();
    }

    const Item = ({ itemData }) => (
        <View style={styles.item}>
            <Text style={styles.title}>Date: {athleteObj[itemData.id].date}</Text>
            <Text style={styles.title}>Felt: {athleteObj[itemData.id].feel}</Text>
            <Text style={styles.title}>Distance: {athleteObj[itemData.id].distance}</Text>
            <Text style={styles.title}>Duration: {athleteObj[itemData.id].duration}</Text>
            <Text style={styles.title}>Notes: {athleteObj[itemData.id].notes}</Text>
        </View>
    );

    const renderItem = ({ item }) => (
        <Item itemData={item} />
    );

    function toggleGroupSelection(group, groupId) {
        let tmpArr = selAthletes
        let tmpGrpTog = groupToggles
        let tmpGroups = groups

        tmpGrpTog[group].selected = !tmpGrpTog[group].selected
        // tmpGroups[groupId][1] = tmpGrpTog[group].selected

        for (const i in tmpGrpTog[group].athletes) {
            const uid = tmpGrpTog[group].athletes[i]
            tmpArr[uid] = tmpGrpTog[group].selected
        }

        setGroupToggles(tmpGrpTog)
        setGroups(tmpGroups)
        setSelAthletes(tmpArr)
    }

    function toggleAthleteSelection(uid) {
        let tmpArr = selAthletes
        tmpArr[uid] = !tmpArr[uid]
        setSelAthletes(tmpArr)
        console.log(selAthletes[uid])
    }

    function submitHandler() {
        try {
            for (const uid in selAthletes) {
                if(selAthletes[uid]) {
                    const taskData = {
                        uid: uid,
                        eventId: eventId,
                        notes: notes,
                        type: 'Cardio',
                        insertDate: new Date(),
                        insertUser: userCtx.userId
                    }
                    postEvent(taskData, token);
                }
            }
        } catch (error) {
            console.log(error);
            Alert.alert('Addition Failed', 'Failed to add task. Please try again later.')
        }
    }

    function clearScreen() {
        setNotes('');
        setDist('');
    }

    return (
        <KeyboardAvoidingView 
            behavior={Platform.OS === "ios" ? "padding" : "height"}>
        <ScrollView>
        <View style={styles.container}>
        <TouchableWithoutFeedback onPress={() =>{ Keyboard.dismiss(); }} >
            <>
            <Text style={styles.headerText}>Cardio Workouts</Text>
            <UserInput
                label="Notes:"
                value={notes}
                onChangeText={setNotes}
                multiline   // ios starts top left
                textAlignVertical='top'  // Android starts top left
                numberOfLines={6}
                style={styles.notesInput}
            />
            </>
        </TouchableWithoutFeedback>
            <Modal
                animationType="slide"
                transparent={true}
                visible={modalLogsVisible}
                onRequestClose={() => {
                    Alert.alert("Modal has been closed.");
                    setAthletesObj([]);
                    setModalLogsVisible(!modalLogsVisible);
                }}
            >
                <View style={styles.modalContainer}>
                    <View style={styles.modalView}>
                        <Text style={styles.modalText}>{logAthletesName}</Text>
                        <FlatList
                            data={athleteLogs}
                            renderItem={renderItem}
                        />
                        <OurButton
                            buttonPressed={() => setModalLogsVisible(!modalLogsVisible)}
                            buttonText="Close"
                            style={{marginHorizontal: 15, marginTop:15}}
                        />
                    </View>
                </View>
            </Modal>
            <Text style={styles.leftText}>Groups:</Text>
            <View style={styles.groupRow}>
            {/* {groups.map((groupName) => (
                <TouchableOpacity
                    onPress={() => toggleGroupSelection(groupName)}
                    style={ groupToggles[groupName].selected ? styles.groupButtonTrue : styles.groupButtonFalse}>
                    <Text style={{fontWeight:'bold'}}>{groupName}</Text>
                </TouchableOpacity>
            ))} */}
            </View>
            <ScrollView horizontal={true}>
                <View style={{paddingHorizontal: 7}}>
                    <Table borderStyle={{borderColor: 'black', borderRadius: 5}}>
                        <Row data={header.tableHead} widthArr={header.widthArr} style={styles.head} textStyle={styles.rosterHeader}/>
                    </Table>
                    <ScrollView style={styles.dataWrapper}>
                        <Table borderStyle={{borderColor: '#C1C0B9'}}>
                            { athletes.map((dataRow, index) => (
                                <TableWrapper key={index} style={ index%2 ? styles.rowA : styles.rowB}>
                                    {dataRow.map((cellData, cellIndex) => (
                                        <Cell 
                                            key={cellIndex} 
                                            style={{width: header.widthArr[cellIndex]}}
                                            data={cellData}
                                            textStyle={[{textAlign: 'center', fontWeight: '200' }]}
                                        />
                                    ))}
                                </TableWrapper>
                            ))}
                        </Table>
                    </ScrollView>
                </View>
            </ScrollView>
        </View>
        <View style={styles.buttonRow}>
            <TouchableOpacity onPress={() => clearScreen()}>
                <Ionicons name="trash-outline" size={28} color="red" style={styles.iconStyle} />
            </TouchableOpacity>
            <OurButton 
                buttonPressed={() => submitHandler()}
                buttonText="Submit"
            />
        </View>
        <Text>{eventId}</Text>
        </ScrollView>
        </KeyboardAvoidingView>
    );
};

const styles = StyleSheet.create({
    container: {
        paddingVertical: 30,
        alignItems: 'center'
    },
    headerText: {
        paddingVertical: 25,
        fontSize: 30,
        color: 'darkgreen',
        fontWeight: 'bold',
        textAlign: 'center',
        paddingRight: 15
    },
    selectDropDownButton: {
        width: '80%',
        height: 40,
        backgroundColor: 'darkgreen',
        borderRadius: 8
    },
    selectDropDown: {
        backgroundColor: 'darkgreen',
        borderBottomLeftRadius: 12,
        borderBottomRightRadius: 12
    },
    selectDropDownRow: {
        backgroundColor: 'darkgreen', 
        borderBottomColor: '#C5C5C5'
    },
    selectDropDownText: {
        color: '#FFF',
        textAlign: 'center',
        fontWeight: 'bold'
    },
    lengthRow: {
        flexDirection: 'row',
        padding: 10,
        alignItems: 'center'
    },
    formText: {
        fontSize: 22,
        textAlign: 'center',
        color: 'darkgreen'
    },
    notesInput: {
        height: 150,
        borderRadius: 8
    },
    iconStyle: {
        paddingHorizontal: 15
    },
    buttonRow: {
        flexDirection: 'row',
        paddingVertical: 10,
        paddingHorizontal: 40,
        justifyContent: 'space-between',
        alignItems: 'center'
    },
    rosterHeader: {
        width: '80%',
        fontSize: 18,
        fontWeight: 'bold',
        color: 'black',
        textAlign: 'center',
        borderColor: 'black'
    },
    head: { 
        height: 50, 
        backgroundColor: 'green',
        borderRadius: 5
    },
    cellText: { 
        textAlign: 'center', 
        fontWeight: '200' 
    },
    clickableText: {
        color: 'orange',
        fontSize: 16,
        textAlign: 'center'
    },
    dataWrapper: { 
        marginTop: -1
    },
    rowA: { 
        flexDirection: 'row',
        height: 40, 
        backgroundColor: '#F7F8FA'
    },
    rowB: { 
        flexDirection: 'row',
        height: 40, 
        backgroundColor: '#ffffff' 
    },
    modalContainer: {
        flex: 1,
        justifyContent: "center",
        alignItems: "center",
        marginVertical: 22
    },
    modalView: {
        width: '80%',
        margin: 20,
        backgroundColor: "white",
        borderRadius: 20,
        padding: 35,
        alignItems: "center",
        shadowColor: "#000",
        shadowOffset: {
          width: 0,
          height: 2
        },
        shadowOpacity: 0.25,
        shadowRadius: 4,
        elevation: 5
    },
    modalText: {
        fontSize: 20,
        fontWeight: 'bold',
        marginBottom: 15,
        textAlign: "center",
        color: 'darkgreen'
    },
    item: {
        borderWidth: 1,
        borderColor: 'green',
        borderRadius: 5,
        marginVertical: 7,
        marginHorizontal: 15,
        padding: 18
    },
    groupRow: {
        flexDirection: 'row',
        flexWrap: 'wrap',
        margin: 12,
        backgroundColor: 'white',
        borderRadius: 8
    },
    groupButtonTrue: {
        borderRadius: 100,
        borderWidth: 1,
        margin: 5,
        padding: 8,
        backgroundColor: 'lightgreen'
    },
    groupButtonFalse: {
        borderRadius: 100,
        borderWidth: 1,
        margin: 5,
        padding: 8,
        backgroundColor: 'red'
    },
    leftText: {
        alignSelf: 'flex-start',
        fontSize: 18,
        fontWeight: 'bold',
        paddingLeft: 10
    }
});

export default CoachCardioScreen;