import React, { useContext, useEffect, useState } from 'react';
import { Alert, Keyboard, KeyboardAvoidingView, ScrollView, StyleSheet, 
    Text, TextInput, TouchableOpacity, TouchableWithoutFeedback, View } from 'react-native';
import { UserContext } from '../../store/context/user-context';
import SelectDropdown from 'react-native-select-dropdown';
import DateTimePicker from '@react-native-community/datetimepicker';
import OurButton from '../../components/OurButton';
import UserInput from '../../components/UserInput';
import { fetchAthleteGroup, fetchCoachTeams, fetchRoster, postEvent } from '../../util/http';
import { Table, TableWrapper, Row, Cell } from 'react-native-table-component';
import { Ionicons } from '@expo/vector-icons';
import { format } from 'date-fns';

const CoachLiftingScreen = () => {
    const userCtx = useContext(UserContext);      // App User Info
    const token = userCtx.token;                 // User Auth Token
    const [teams, setTeams] = useState([]);

    const [date, setDate] = useState(new Date()); // Date of workout
    const [mode, setMode] = useState('date');     // Date picker mode
    const [show, setShow] = useState(false);      // Show or Hide Date Picker
    const [time, setTime] = useState(new Date()); // Time of workout

    const [tableForm, setTableForm] = useState([]);
    const [tableData, setTableData] = useState([]);
    const [notes, setNotes] = useState('');

    const UNITS = [
        {id: 0, name: 'kg'},
        {id: 1, name: 'lbs'},
        {id: 2, name: '%'}];

    const test = {
        0: "works?",
        A: "How bout now?"
    };

    const header = {
        tableHead: ['Sets', 'Reps', 'Exercise', 'Weight', 'Units', 'Rest', 'X'],
        widthArr: [75, 75, 200, 75, 75, 75, 40]
    }

    useEffect(() => {
        function primeDataTable() {
            const tempTableForm = [];
            const row = ['','','','','kg',''];

            const tmpTableData = tableData;
            tmpTableData[0] = row; 
            setTableData(tmpTableData);

            tempTableForm.push([
                <TextInput 
                    keyboardType='numeric' 
                    autoCorrect={false}
                    maxLength={3}
                    onChangeText={text => setTableCell(0,0,text)}
                    style={styles.cellText}/>,
                <TextInput 
                    autoCorrect={false}
                    maxLength={10}
                    onChangeText={text => setTableCell(1,0,text)}
                    style={styles.cellText}/>,
                <TextInput 
                    maxLength={100}
                    onChangeText={text => setTableCell(2,0,text)}
                    style={styles.cellText}/>,
                <TextInput 
                    keyboardType='numeric' 
                    autoCorrect={false} 
                    maxLength={3} 
                    onChangeText={text => setTableCell(3,0,text)}
                    style={styles.cellText}/>,
                <SelectDropdown
                    data={UNITS}
                    defaultValueByIndex={0}
                    onSelect={(selectedItem, index) => {
                        setTableCell(4,0,selectedItem.name);
                    }}
                    buttonTextAfterSelection={(selectedItem, index) => {
                        return selectedItem.name
                    }}
                    rowTextForSelection={(item, index) => {
                        return item.name
                    }}
                    buttonStyle={styles.sDDUnitsButton}
                    buttonTextStyle={styles.sDDUnitsText}
                    renderDropdownIcon={isOpened => {
                        return <Ionicons name={isOpened ? 'chevron-up-circle-sharp' : 'chevron-down-circle-outline'} color={'darkgreen'} size={18} />;
                    }}
                    dropdownIconPosition={'right'}
                    dropdownStyle={styles.sDDUnits}
                    rowStyle={styles.sDDUnitsRow}
                    rowTextStyle={styles.sDDUnitsText}
                />,
                <TextInput 
                    keyboardType='numeric' 
                    autoCorrect={false}
                    maxLength={3}
                    onChangeText={text => setTableCell(5,0,text)}
                    style={styles.cellText}/>,
                <TouchableOpacity onPress={() => removeTableRow(0)}>
                    <Ionicons name="trash-outline" size={22} color="red" style={styles.cellText} />
                </TouchableOpacity>]);

            setTableForm(tempTableForm);
        }

        async function getDBTeams() {
            const results = await fetchCoachTeams(userCtx.userId, token);
            setTeams(results);
        }
    
        primeDataTable();
        getDBTeams();
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
        const l = tableForm.length;

        const row = ['','','','','kg',''];
        const tmpTableData = tableData;
        tmpTableData[l] = row;
        setTableData(tmpTableData);

        const tempTableForm = [...tableForm,
            [<TextInput 
                keyboardType='numeric' 
                autoCorrect={false}
                maxLength={3}
                onChangeText={text => setTableCell(0,l,text)}
                style={styles.cellText}/>,
            <TextInput 
                autoCorrect={false}
                maxLength={10}
                onChangeText={text => setTableCell(1,l,text)}
                style={styles.cellText}/>,
            <TextInput 
                maxLength={100}
                onChangeText={text => setTableCell(2,l,text)}
                style={styles.cellText}/>,
            <TextInput 
                keyboardType='numeric' 
                autoCorrect={false} 
                maxLength={3} 
                onChangeText={text => setTableCell(3,l,text)}
                style={styles.cellText}/>,
            <SelectDropdown
                data={UNITS}
                defaultValueByIndex={0}
                onSelect={(selectedItem, index) => {
                    setTableCell(4,l,selectedItem.name);
                }}
                buttonTextAfterSelection={(selectedItem, index) => {
                    return selectedItem.name
                }}
                rowTextForSelection={(item, index) => {
                    return item.name
                }}
                buttonStyle={styles.sDDUnitsButton}
                buttonTextStyle={styles.sDDUnitsText}
                renderDropdownIcon={isOpened => {
                    return <Ionicons name={isOpened ? 'chevron-up-circle-sharp' : 'chevron-down-circle-outline'} color={'darkgreen'} size={18} />;
                }}
                dropdownIconPosition={'right'}
                dropdownStyle={styles.sDDUnits}
                rowStyle={styles.sDDUnitsRow}
                rowTextStyle={styles.sDDUnitsText}
            />,
            <TextInput 
                keyboardType='numeric' 
                autoCorrect={false}
                maxLength={3}
                onChangeText={text => setTableCell(5,l,text)}
                style={styles.cellText}/>,
            <TouchableOpacity onPress={() => removeTableRow(l)}>
                <Ionicons name="trash-outline" size={22} color="red" style={styles.cellText} />
            </TouchableOpacity>]
        ];

        setTableForm(tempTableForm);
    }

    function removeTableRow( row ) {
        const tempTableForm = [...tableForm];
        const tempTableData = [...tableData];
        tempTableForm.splice(row,1);
        tempTableData.splice(row,1);
        setTableForm(tempTableForm);
        setTableData(tempTableData);
    }

    function setTableCell(x,y,value) {
        const tempTableData = tableData;
        tempTableData[y][x] = value;
        setTableData(tempTableData);
    }

    const submit = () => {
        try {
            const eventData = {
                uid: 'bHQPLHPJsZhgLo4nZb9a4erhiI82',
                teamId: userCtx.teamId,
                teamName: userCtx.teamName,
                notes: notes,
                date: format(date, "yyyy-MM-dd"),
                type: 'Lifting',
                startTime: format(time, "h:mm a"),
                insertDate: new Date(),
                workout: tableData
            }
            postEvent(eventData, token);
            Alert.alert('Lift Added', 'Your lift has been submitted.')
        } catch (error) {
            console.log(error);
            Alert.alert('Addition Failed', 'Failed to add event. Please try again later.')
        }
    }

    const clearForm = () => {
        const placeholder = true;
    }

    return (
        <ScrollView>
        <View style={styles.container}>
            <Text style={styles.title}>Weight Training</Text>
            <View style={styles.lengthRow}></View>
            <TouchableOpacity onPress={showDatepicker}>
                <View style={styles.lengthRow}>
                    <Text style={styles.dateText}>Date: {format(time, "MMMM do, yyyy")}</Text>
                    <Ionicons name="calendar-outline" size={24} color="darkgreen"/>
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
                    <Text style={styles.dateText}>Time: {format(time, "h:mm a")}</Text>
                    <Ionicons name="time-outline" size={24} color="darkgreen" />
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
            <SelectDropdown
                data={teams}
                onSelect={(selectedItem, index) => {
                    const teamData = {
                        name: selectedItem.name,
                        id: selectedItem.id
                    };
                    userCtx.switchTeam(teamData);
                    // selectTeamHandler(selectedItem.id);
                }}
                defaultButtonText={userCtx.teamName}
                buttonTextAfterSelection={(selectedItem, index) => {
                    return selectedItem.name
                }}
                rowTextForSelection={(item, index) => {
                    return item.name
                }}
                buttonStyle={styles.selectDropDownButton}
                buttonTextStyle={styles.selectDropDownText}
                renderDropdownIcon={isOpened => {
                    return <Ionicons name={isOpened ? 'chevron-up-circle-sharp' : 'chevron-down-circle-outline'} color={'#FFF'} size={18} />;
                }}
                dropdownIconPosition={'right'}
                dropdownStyle={styles.selectDropDown}
                rowStyle={styles.selectDropDownRow}
                rowTextStyle={styles.selectDropDownText}
            />
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
                buttonPressed={addTableRow}
                buttonText="Add Row"
                style={{marginBottom: 15}}
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
            <View style={styles.lengthRow}>
                <OurButton
                    buttonPressed={submit}
                    buttonText="Submit"
                    style={{margin: 15}}
                />
                <OurButton
                    buttonPressed={clearForm}
                    buttonText="Clear"
                    style={{margin: 15}}
                />
            </View>
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
    },
    notesInput: {
        height: 150,
        borderRadius: 8,
    }
});

export default CoachLiftingScreen;