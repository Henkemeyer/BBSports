import React, { useContext, useEffect, useState } from 'react';
import { Alert, Keyboard, KeyboardAvoidingView, ScrollView, StyleSheet, 
    Text, TextInput, TouchableOpacity, TouchableWithoutFeedback, View } from 'react-native';
import { UserContext } from '../store/context/user-context';
import SelectDropdown from 'react-native-select-dropdown';
import DateTimePicker from '@react-native-community/datetimepicker';
import OurButton from '../components/OurButton';
import UserInput from '../components/UserInput';
import { Table, TableWrapper, Row, Cell } from 'react-native-table-component';
import { Ionicons } from '@expo/vector-icons';
import { format } from 'date-fns';

const CoachLiftingScreen = () => {
    const userCtx = useContext(UserContext);      // App User Info
    const token = userCtx.token;                  // User Auth Token

    const [date, setDate] = useState(new Date()); // Date of workout
    const [mode, setMode] = useState('date');     // Date picker mode
    const [show, setShow] = useState(false);      // Show or Hide Date Picker
    const [time, setTime] = useState(new Date()); // Time of workout

    const [tableData, setTableData] = useState([]);
    const [notes, setNotes] = useState('');

    const UNITS = ['kg','lbs','%'];

    const header = {
        tableHead: ['Sets', 'Reps', 'Exercise', 'Weight', 'Units'],
        widthArr: [75, 75, 200, 75, 40]
    }

    useEffect(() => {
        function dummyFunction() {
            setTableData([
                [<TextInput keyboardType='numeric' autoCorrect={false} maxLength={3}/>,
                '3-5', 'Bench', 135, 'lbs'],
                [<TextInput keyboardType='numeric' autoCorrect={false} maxLength={3}/>,
                '8-10', 'Squat', 235, 'lbs'],
                [<TextInput keyboardType='numeric' autoCorrect={false} maxLength={3}/>,
                '13-15', 'Lunge', 35, 'lbs']
            ]);
        }
    
        dummyFunction();
    }, []);

    const onDateChange = (event, selectedDate) => {
        if(event.type != 'dismissed')
        {
            const currentDate = selectedDate;
            setDate(currentDate);
        }
        setShow(false);
    };

    const onTimeChange = (event, selectedTime) => {
        if(event.type != 'dismissed')
        {
            const currentTime = selectedTime;
            setTime(currentTime);
        }
        setShow(false);
    };
  
    const showMode = (currentMode) => {
      setShow(true);
      setMode(currentMode);
    };
  
    const showDatepicker = () => {
      showMode('date');
    };

    const showTimepicker = () => {
        showMode('time');
    };

    const addTableRow = () => {
        const tempTableData = [...tableData,
            [<TextInput keyboardType='numeric' autoCorrect={false} maxLength={3}/>,
            'b','c','d','e']];

        setTableData(tempTableData);
    }

    return (
        <ScrollView>
        <View style={styles.container}>
            <Text style={styles.title}>Weight Training</Text>
            <View style={styles.lengthRow}></View>
            <TouchableOpacity onPress={showDatepicker}>
                <View style={styles.lengthRow}>
                    <Text style={styles.formText}>Date: {format(time, "MMMM do, yyyy")}</Text>
                    <Ionicons name="calendar-outline" size={24} color="darkgreen" style={styles.iconStyle} />
                </View>
            </TouchableOpacity>
            {show && (
                <DateTimePicker
                    testID="datePicker"
                    value={date}
                    mode={mode}
                    is24Hour={true}
                    onChange={onDateChange}
                />
            )}
            <TouchableOpacity onPress={showTimepicker}>
                <View style={styles.lengthRow}>
                    <Text style={styles.formText}>Time: {format(time, "H:mm a")}</Text>
                    <Ionicons name="time-outline" size={24} color="darkgreen" style={styles.iconStyle} />
                </View>
            </TouchableOpacity>
            {show && (
                <DateTimePicker
                    testID="timePicker"
                    value={time}
                    mode={mode}
                    is24Hour={false}
                    onChange={onTimeChange}
                />
            )}
            <ScrollView horizontal={true} style={{paddingVertical: 20}}>
                <View>
                    <Table borderStyle={{borderColor: 'black', borderRadius: 5}}>
                        <Row data={header.tableHead} widthArr={header.widthArr} style={styles.head} textStyle={styles.liftsHeader}/>
                    </Table>
                    <ScrollView style={styles.dataWrapper}>
                        <Table borderStyle={{borderColor: '#C1C0B9'}}>
                            { tableData.map((dataRow, index) => (
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
                buttonPressed={addTableRow}
                buttonText="Add Row"
            />
            <UserInput
                label="Notes:"
                value={notes}
                onChangeText={setNotes}
                multiline   // ios starts top left
                textAlignVertical='top'  // Android starts top left
                numberOfLines={6}
                style={styles.notesInput}
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
        fontSize: 25,
        textAlign: 'center',
        textAlignVertical: 'center'
    },
    lengthRow: {
        flexDirection: 'row',
        padding: 10,
        width: '100%',
        justifyContent: 'space-evenly',
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
    notesInput: {
        height: 150,
        borderRadius: 8
    }
});

export default CoachLiftingScreen;