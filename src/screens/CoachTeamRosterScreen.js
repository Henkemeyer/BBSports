import React, { useContext, useEffect, useState } from 'react';
import { Modal, ScrollView, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import { Table, TableWrapper, Row, Cell } from 'react-native-table-component';
import { Ionicons } from '@expo/vector-icons';
import OurButton from '../components/OurButton';
import UserInput from '../components/UserInput';
import { UserContext } from '../store/context/user-context';
import { fetchRoster, fetchUser, patchAthlete, postAthlete } from '../util/http';

const CoachTeamRosterScreen = ( {navigation} ) => {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [modalVisible, setModalVisible] = useState(false);
    const [uidValid, setUidValid] = useState(false);
    const [recruitUid, setRecruitUid] = useState('');
    const [recruit, setRecruit] = useState([]);

    const [athletesObj, setAthletesObj] = useState([]);
    const [roster, setRoster] = useState([]);

    const header = {
        tableHead: ['Name', 'Group', 'Year', 'Status', 'Cut'],
        widthArr: [200, 200, 50, 50, 40]
    }

    useEffect(() => {
        async function getDBAthletes() {
            const dbAthletes = await fetchRoster(userCtx.team.id, token);
            const rosterArr = [];
            const holdAthletesObj = [];

            for (const key in dbAthletes.data) {
                const athObj = {
                    id: key,
                    name: dbAthletes.data[key].fullName,
                    group: dbAthletes.data[key].groupName,
                    age: dbAthletes.data[key].age,
                    status: dbAthletes.data[key].status,
                    uid: dbAthletes.data[key].uid
                    // date: new Date(response.data[key].date)
                };
                holdAthletesObj.push(athObj);

                const athArr = [
                    dbAthletes.data[key].fullName,
                    dbAthletes.data[key].groupName,
                    dbAthletes.data[key].age,
                    dbAthletes.data[key].status,
                    key
                ]
                rosterArr.push(athArr);
            }
            setAthletesObj(holdAthletesObj);
            setRoster(rosterArr);
        }
    
        getDBAthletes();
    }, [userCtx.team.id]);

    const cutElement = (data, index) => (
        <View style={styles.cutButton}>
            <TouchableOpacity onPress={() => cutAthlete(data, index)}>
                <Ionicons name='remove-circle-outline' size={17} color="red" />
            </TouchableOpacity>
        </View>
    );

    function cutAthlete(data, index) {
        const patchStatus = { status: "X" };
        patchAthlete(data, patchStatus);
        const tempRoster = roster;
        tempRoster.splice(index,1)
        setRoster(tempRoster);
        console.log(roster);
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
                    const athleteObj = {
                        uid: key,
                        fullName: response.data[key].fullName,
                        location: response.data[key].location
                    };
                    setRecruit(athleteObj);
                }
                setUidValid(true);
            }
        })
        .catch(function (error) {
            console.log(error);
            setUidValid(false);
        });
    }
    
    function closeModal(action) {
        if (action === 'recruit') {
            console.log('Here');
            const athleteData = {
                uid: recruitUid,
                fullName: recruit.fullName,
                status: 'P', // (P)ending, (A)ctive, (T)erminated
                teamId: userCtx.team.id,
                age: 29
            }
            console.log(athleteData);
            postAthlete(athleteData, userCtx.token);
        }
        
        setRecruitUid('');
        setUidValid(false);
        setModalVisible(!modalVisible);
        setRecruit({});
    }

    return (
        <View style={styles.container}>
            <Modal
                animationType="slide"
                transparent={true}
                visible={modalVisible}
                onRequestClose={() => {
                Alert.alert("Modal has been closed.");
                setModalVisible(!modalVisible);
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
                                buttonPressed={() => closeModal('cancel')}
                                buttonText="Cancel"
                                style={{marginHorizontal: 15, marginTop:15}}
                            />
                            { uidValid ? <>
                                <OurButton
                                    buttonPressed={() => closeModal('recruit')}
                                    buttonText="Recruit"
                                    style={{marginHorizontal: 15, marginTop:15}}
                                />
                            </> : null}
                        </View>
                    </View>
                </View>
            </Modal>

            <Text style={styles.rosterHeader}>{userCtx.team.name} Team Roster</Text>
            <ScrollView horizontal={true}>
                <View>
                    <Table borderStyle={{borderColor: '#C1C0B9'}}>
                        <Row data={header.tableHead} widthArr={header.widthArr} style={styles.head} textStyle={styles.cellText}/>
                    </Table>
                    <ScrollView style={styles.dataWrapper}>
                        <Table borderStyle={{borderColor: '#C1C0B9'}}>
                            { roster.map((dataRow, index) => (
                                <TableWrapper key={index} style={ index%2 ? styles.rowA : styles.rowB}>
                                    {dataRow.map((cellData, cellIndex) => (
                                        <Cell 
                                            key={cellIndex} 
                                            style={{width: header.widthArr[cellIndex]}}
                                            data={cellIndex === 4 ? cutElement(cellData, index) : cellData}
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
                buttonPressed={() => setModalVisible(!modalVisible)}
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
        borderTopWidth: 5,
        borderColor: 'darkgreen',
        width: '80%',
        fontSize: 30,
        fontWeight: 'bold',
        margin: 15,
        paddingTop: 10,
        color: 'darkgreen',
        textAlign: 'center'
    },
    rosterHeader: {
        width: '80%',
        fontSize: 20,
        fontWeight: 'bold',
        margin: 5,
        paddingVertical: 10,
        color: 'darkgreen',
        textAlign: 'center'
    },
    viewRow: {
        flexDirection: 'row',
        justifyContent: 'space-between',
    },
    head: { 
        height: 50, 
        backgroundColor: '#6F7BD9' 
    },
    cellText: { 
        textAlign: 'center', 
        fontWeight: '200' 
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
        marginTop: 22
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
    }
});

export default CoachTeamRosterScreen;