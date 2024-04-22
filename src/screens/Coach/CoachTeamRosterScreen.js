import React, { useContext, useEffect, useState } from 'react';
import { Alert, FlatList, Modal, ScrollView, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import { Table, TableWrapper, Row, Cell } from 'react-native-table-component';
import { Ionicons } from '@expo/vector-icons';
import OurButton from '../../components/OurButton';
import UserInput from '../../components/UserInput';
import { UserContext } from '../../store/context/user-context';
import { fetchCardioLog, fetchRoster, fetchUser, patchAthlete, postAthlete } from '../../util/http';

const CoachTeamRosterScreen = ( {navigation} ) => {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [modalRecruitVisible, setModalRecruitVisible] = useState(false);
    const [uidValid, setUidValid] = useState(false);
    const [recruitUid, setRecruitUid] = useState('');
    const [recruit, setRecruit] = useState([]);

    const [modalLogsVisible, setModalLogsVisible] = useState(false);
    const [athleteLogs, setAthleteLogs] = useState([]);
    const [athleteObj, setAthletesObj] = useState([]);
    const [logAthletesName, setLogAthletesName] = useState('');
    const [roster, setRoster] = useState([]);

    const header = {
        tableHead: ['Name', 'Group', 'Year', 'Status', 'Cut'],
        widthArr: [200, 200, 60, 75, 40]
    }

    useEffect(() => {
        async function getDBAthletes() {
            const dbAthletes = await fetchRoster(userCtx.teamId, token);
            const rosterArr = [];

            for (const key in dbAthletes.data) {
                const athArr = [
                    <TouchableOpacity 
                        onPress={() => showLogsHandler(dbAthletes.data[key].uid, dbAthletes.data[key].fullName)}
                    >
                        <Text style={styles.clickableText}>{dbAthletes.data[key].fullName}</Text>
                    </TouchableOpacity>,
                    dbAthletes.data[key].groupName,
                    dbAthletes.data[key].age,
                    dbAthletes.data[key].status,
                    <View style={styles.cutButton}>
                        <TouchableOpacity onPress={() => cutAthlete(key, rosterArr.length-1)}>
                            <Ionicons name='remove-circle-outline' size={17} color="red" />
                        </TouchableOpacity>
                    </View>
                ]
                rosterArr.push(athArr);
            }
            setRoster(rosterArr);
        }
    
        getDBAthletes();
    }, [userCtx.teamId]);

    function cutAthlete(data, index) {
        const patchStatus = { status: "X" };
        patchAthlete(data, patchStatus);
        const tempRoster = roster;
        tempRoster.splice(index,1)
        setRoster(tempRoster);
        // setAthletesObj(current =>
        //     current.filter(athlete => {
        //       return athlete.id !== data;
        //     }),
        // );
    };

    function searchHandler() {
        fetchUser(recruitUid, token).then(function (response) {
            if (Object.keys(response.data).length === 0 ) {
                // Athlete not found warning
                setUidValid(false);
            }
            else {
                for (const key in response.data) {
                    const recruitObj = {
                        uid: key,
                        fullName: response.data[key].fullName,
                        location: response.data[key].location
                    };
                    setRecruit(recruitObj);
                }
                setUidValid(true);
            }
        })
        .catch(function (error) {
            console.log(error);
            setUidValid(false);
        });
    }
    
    function closeRecruitModal(action) {
        if (action === 'recruit') {
            const athleteData = {
                uid: recruitUid,
                fullName: recruit.fullName,
                status: 'P', // (P)ending, (A)ctive, (T)erminated
                teamId: userCtx.teamId
            }
            postAthlete(athleteData, userCtx.token);
        }
        
        setRecruitUid('');
        setUidValid(false);
        setModalRecruitVisible(!modalRecruitVisible);
        setRecruit({});
    }

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

    return (
        <View style={styles.container}>
            <Modal
                animationType="slide"
                transparent={true}
                visible={modalRecruitVisible}
                onRequestClose={() => {
                    Alert.alert("Modal has been closed.");
                    setModalRecruitVisible(!modalRecruitVisible);
                }}
            >
                <View style={styles.modalContainer}>
                    <View style={styles.modalView}>
                        <Text style={styles.modalText}>Find Athlete</Text>
                        <UserInput
                            label="User ID"
                            value={recruitUid}
                            onChangeText={setRecruitUid}
                        />
                        <OurButton
                            buttonPressed={() => searchHandler()}
                            buttonText="Search"
                        />
                        <Text style={styles.modalText}>Name: {recruit.fullName}</Text>
                        <Text style={styles.modalText}>Location: {recruit.location}</Text>
                        <View style={styles.viewRow}>
                            <OurButton
                                buttonPressed={() => closeRecruitModal('cancel')}
                                buttonText="Cancel"
                                style={{marginHorizontal: 15, marginTop:15}}
                            />
                            { uidValid ? <>
                                <OurButton
                                    buttonPressed={() => closeRecruitModal('recruit')}
                                    buttonText="Recruit"
                                    style={{marginHorizontal: 15, marginTop:15}}
                                />
                            </> : null}
                        </View>
                    </View>
                </View>
            </Modal>
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

            <Text style={styles.orgTitle}>{userCtx.teamName} Team Roster</Text>
            <ScrollView horizontal={true}>
                <View>
                    <Table borderStyle={{borderColor: 'black', borderRadius: 5}}>
                        <Row data={header.tableHead} widthArr={header.widthArr} style={styles.head} textStyle={styles.rosterHeader}/>
                    </Table>
                    <ScrollView style={styles.dataWrapper}>
                        <Table borderStyle={{borderColor: '#C1C0B9'}}>
                            { roster.map((dataRow, index) => (
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
            <OurButton 
                buttonPressed={() => setModalRecruitVisible(!modalRecruitVisible)}
                buttonText="Recruit"
                style={styles.createButton}/>
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        margin: 20,
        paddingTop: 10,
        alignItems: 'center',
        justifyContent: 'center',
    },
    orgTitle: {
        width: '80%',
        fontSize: 30,
        fontWeight: 'bold',
        margin: 15,
        paddingTop: 10,
        color: 'darkgreen',
        textAlign: 'center'
    },
    viewRow: {
        flexDirection: 'row',
        justifyContent: 'space-between',
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
    cutButton: {
        alignItems: 'center',
        justifyContent: 'center'
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
        textAlign: "center"
    },
    item: {
        borderWidth: 1,
        borderColor: 'green',
        borderRadius: 5,
        marginVertical: 7,
        marginHorizontal: 15,
        padding: 18
    }
});

export default CoachTeamRosterScreen;