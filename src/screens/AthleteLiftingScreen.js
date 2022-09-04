import React, { useContext, useEffect, useState } from 'react';
import { Alert, Keyboard, KeyboardAvoidingView, ScrollView, StyleSheet, 
    Text, TextInput, TouchableOpacity, TouchableWithoutFeedback, View } from 'react-native';
import { UserContext } from '../store/context/user-context';
import SelectDropdown from 'react-native-select-dropdown';
import DateTimePicker from '@react-native-community/datetimepicker';
import OurButton from '../components/OurButton';
import UserInput from '../components/UserInput';
import { fetchAthleteGroup, fetchCoachTeams, fetchRoster, postEvent } from '../util/http';
import { Table, TableWrapper, Row, Cell } from 'react-native-table-component';
import { Ionicons } from '@expo/vector-icons';
import { format } from 'date-fns';

const AthleteLiftingScreen = () => {
    const userCtx = useContext(UserContext);      // App User Info
    const token = userCtx.token;                 // User Auth Token
    const [tableForm, setTableForm] = useState([]);
    const [tableData, setTableData] = useState([]);
    const [sets, setSets] = useState(1);

    const UNITS = [
        {id: 1, name: 'kg'},
        {id: 2, name: 'lbs'},
        {id: 3, name: '%'}];
    
    const header = {
        tableHead: ['Sets', 'Reps', 'Exercise', 'Weight', 'Units', 'Rest', 'Reps 1', 'Wt 1'],
        widthArr: [75, 75, 200, 75, 75, 75, 75, 75]
    };

    function setTableCell(x,y,value) {
        const tempTableData = tableData;
        tempTableData[y][x] = value;
        setTableData(tempTableData);
    }

    const submit = () => {
        try {
            const liftingData = {
                uid: userCtx.userId,
                teamId: userCtx.teamId,
                date: format(date, "yyyy-MM-dd"),
                insertDate: new Date(),
                workout: { tableData }
            }
            postLiftLog(liftingData, token);
            Alert.alert('Lift Added', 'Your lift has been submitted.')
        } catch (error) {
            console.log(error);
            Alert.alert('Addition Failed', 'Failed to add event. Please try again later.')
        }
    }

    return (
        <ScrollView>
        <View style={styles.container}>
            <Text style={styles.title}>Weight Training</Text>
            <Text>Title: (Legs?)</Text>
            <Text>Date: Today</Text>
            <Text>Custom list Comp:</Text>
            <ScrollView horizontal={true} style={{paddingVertical: 20}}>
                <View>
                    <Table borderStyle={{borderColor: 'black', borderRadius: 5}}>
                        <Row data={header.tableHead} widthArr={header.widthArr} style={styles.head} textStyle={styles.liftsHeader}/>
                    </Table>
                    <ScrollView style={styles.dataWrapper}>
                        <Table borderStyle={{borderColor: '#C1C0B9'}}>
                            { tableForm.map((dataRow, index) => (
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
                buttonPressed={submit}
                buttonText="Submit"
                style={{margin: 15}}
            />
        </View>
        </ScrollView>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        margin: 20,
        paddingTop: 10,
        alignItems: 'center'
    },
    title: {
        paddingTop: 15,
        fontSize: 25,
        textAlign: 'center',
        textAlignVertical: 'center',
        color: 'darkgreen'
    },
    dateText: {
        paddingTop: 5,
        paddingRight: 10,
        fontSize: 22,
        textAlign: 'center',
        color: 'darkgreen'
    },
    lengthRow: {
        flexDirection: 'row',
        marginVertical: 10,
        width: '100%',
        alignItems: 'center'
    },
    header: {
        flexDirection: 'row',
        justifyContent: 'space-around',
        paddingVertical: 10
    },
    headerText: {
        fontSize:16
    },
    viewRow: {
        flexDirection: 'row',
        justifyContent: 'center',
        alignItems: 'center'
    },
    liftsHeader: {
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
    sDDUnitsButton: {
        width: '100%',
        height: '90%',
        backgroundColor: '#F7F8FA',
        borderRadius: 8
    },
    sDDUnits: {
        backgroundColor: 'darkgreen',
        borderBottomLeftRadius: 12,
        borderBottomRightRadius: 12
    },
    sDDUnitsRow: {
        backgroundColor: '#F7F8FA',
        borderBottomColor: '#C5C5C5'
    },
    sDDUnitsText: {
        // color: '#FFF',
        textAlign: 'center',
        fontWeight: 'bold'
    }
});

export default AthleteLiftingScreen;