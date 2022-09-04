import React, { useContext, useEffect, useState } from 'react';
import { Alert, Modal, ScrollView, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import { Table, TableWrapper, Row, Cell } from 'react-native-table-component';
import OurButton from '../components/OurButton';
import UserInput from '../components/UserInput';
import { postEquipment, fetchEquipment, patchEquipment } from '../util/http';
import { UserContext } from '../store/context/user-context';
import { Ionicons } from '@expo/vector-icons';
import { format } from 'date-fns';

const EquipmentScreen = () => {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [modalVisible, setModalVisible] = useState(false);
    const [newName, setNewName] = useState('');
    const [equipment, setEquipment] = useState([]);

    const header = {
        tableHead: ['Name', 'Distance', 'Date Added', ''],
        widthArr: [200, 100, 100, 40]
    }
    
    useEffect(() => {
        async function getDBEquipment() {
            const dbEquipment = await fetchEquipment(userCtx.userId, token);
            const equipArr = [];

            for (const key in dbEquipment.data) {
                if(dbEquipment.data[key].status != 'X') {
                    const tmpArr = [
                        dbEquipment.data[key].equipName,
                        dbEquipment.data[key].distance,
                        dbEquipment.data[key].insertDate,
                        key
                    ]
                    equipArr.push(tmpArr);
                }
            }
            setEquipment(equipArr);
        }
    
        getDBEquipment();
    }, [token]);

    const retireElement = (data, index) => (
        <View style={styles.retireButton}>
            <TouchableOpacity onPress={() => retireHandler(data, index)}>
                <Ionicons name='remove-circle-outline' size={17} color="red" />
            </TouchableOpacity>
        </View>
    );

    function retireHandler(data, index) {
        Alert.alert(
            "Warning",
            "Are you sure you want to delete that?",
            [{
                text: "Cancel",
                onPress: () => console.log("Cancelled"),
                style: "cancel"
            },
            { text: "Yes", onPress: () => confirm() }]
        );

        function confirm() {
            const patchStatus = { status: "X" };
            patchEquipment(data, patchStatus);
            const tempEquipment = equipment;
            tempEquipment.splice(index,1)
            setEquipment(tempEquipment);
        }
    };

    async function closeModal(action) {
        if (action === 'add') {
            const equipData = {
                uid: userCtx.userId,
                equipName: newName,
                status: 'A', 
                distance: 0,
                insertDate: format(new Date(), "yyyy-MM-dd"),
            }
            await postEquipment(equipData, userCtx.token)
            .then(function (response) {
                const tmpArr = [
                    newName,
                    0,
                    format(new Date(), "yyyy-MM-dd"),
                    response.data.name
                ]
                setEquipment([...equipment, response.data])
            })
            .catch(function (error) {
                console.log(error);
            });
        }
        
        setModalVisible(!modalVisible);
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
                        <Text style={styles.modalText}>Add Equipment</Text>
                        <UserInput
                            label="Name:"
                            value={newName}
                            onChangeText={setNewName}
                        />
                        <View style={styles.viewRow}>
                            <OurButton
                                buttonPressed={() => closeModal('cancel')}
                                buttonText="Cancel"
                                style={{marginHorizontal: 15, marginTop:15}}
                            />
                            <OurButton
                                buttonPressed={() => closeModal('add')}
                                buttonText="Add"
                                style={{marginHorizontal: 15, marginTop:15}}
                            />
                        </View>
                    </View>
                </View>
            </Modal>

            <Text style={styles.orgTitle}>Equipment</Text>
            <ScrollView horizontal={true}>
                <View>
                    <Table borderStyle={{borderColor: 'black', borderRadius: 5}}>
                        <Row data={header.tableHead} widthArr={header.widthArr} style={styles.head} textStyle={styles.equipmentHeader}/>
                    </Table>
                    <ScrollView style={styles.dataWrapper}>
                        <Table borderStyle={{borderColor: '#C1C0B9'}}>
                            { equipment.map((dataRow, index) => (
                                <TableWrapper key={index} style={ index%2 ? styles.rowA : styles.rowB}>
                                    {dataRow.map((cellData, cellIndex) => (
                                        <Cell 
                                            key={cellIndex} 
                                            style={{width: header.widthArr[cellIndex]}}
                                            data={cellIndex === 3 ? retireElement(cellData, index) : cellData}
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
                buttonText="Add"/>
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
        marginBottom: 15,
        color: 'darkgreen',
        textAlign: 'center'
    },
    viewRow: {
        flexDirection: 'row',
        justifyContent: 'space-between',
    },
    equipmentHeader: {
        width: '80%',
        fontSize: 17,
        fontWeight: 'bold',
        color: 'black',
        textAlign: 'center',
        borderColor: 'black',
        paddingLeft: 9
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
    retireButton: {
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

export default EquipmentScreen;
