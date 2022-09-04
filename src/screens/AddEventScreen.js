import React, { useContext, useEffect, useState } from 'react';
import { Alert, Keyboard, KeyboardAvoidingView, Platform, ScrollView, StyleSheet, Text, 
    TouchableOpacity, TouchableWithoutFeedback, View } from 'react-native';
import SelectDropdown from 'react-native-select-dropdown';
import DateTimePicker from '@react-native-community/datetimepicker';
import { format } from 'date-fns';
import { fetchAthleteGroup, fetchCoachTeams, fetchRoster, postEvent } from '../util/http';
import { UserContext } from '../store/context/user-context';
import UserInput from '../components/UserInput';
import OurButton from '../components/OurButton';
import CheckBox from '../components/CheckBox';
import Colors from '../constants/ColorThemes';
import { Ionicons } from '@expo/vector-icons';

const AddEventScreen = ( ) => {
    const userCtx = useContext(UserContext);      // App User Info
    const token = userCtx.token;                  // User Auth Token
    const [teams, setTeams] = useState([]);       // List of Coach's Teams
    const [onOwn, setOnOwn] = useState(false);    // If it's a solo task or not

    const [date, setDate] = useState(new Date()); // Date of workout
    const [showDate, setShowDate] = useState(false);      // Show or Hide Date Picker

    const onDateChange = (event, selectedDate) => {
        if(event.type != 'dismissed')
        {
            setDate(selectedDate);
        }
        setShowDate(false);
    };

    const showDateMode = (currentMode) => {
        setShowDate(true);
    };
  
    const showDatepicker = () => {
        showDateMode('date');
    };

    const [startTime, setStartTime] = useState(new Date()); // Time of workout
    const [showStartTime, setShowStartTime] = useState(false);      // Show or Hide Date Picker

    const onStartTimeChange = (event, selectedTime) => {
        if(event.type != 'dismissed')
        {
            setStartTime(selectedTime);
        }
        setShowStartTime(false);
    };

    const showStartTimepicker = () => {
        showTimeMode('startTime');
    };

    const [endTime, setEndTime] = useState(new Date());     // End time of workout
    const [showEndTime, setShowEndTime] = useState(false);      // Show or Hide Date Picker

    const onEndTimeChange = (event, selectedTime) => {
        if(event.type != 'dismissed')
        {
            setEndTime(selectedTime);
        }
        setShowEndTime(false);
    };
    
    const showEndTimepicker = () => {
        showTimeMode('endTime');
    };

    const [location, setLoc] = useState('');        // Location to meet
    const [type, setType] = useState('Cardio');   // Event Type
    const [types, setTypes] = useState([
        {id:0, name: 'Cardio'},
        {id:1, name: 'Weights'},
        {id:2, name: 'Meet'},
        {id:3, name: 'Activity'}
    ]);

    const toggleOnOwn = () => {
        setOnOwn(!onOwn);
        console.log(onOwn);
        if(onOwn) {
            setTypes([
                {id:0, name: 'Cardio'},
                {id:1, name: 'Weights'}
            ]);

            if(type === 'Meet' || type === 'Activity') {
                setType('Cardio');
            }
        } else {
            setTypes([
                {id:0, name: 'Cardio'},
                {id:1, name: 'Weights'},
                {id:2, name: 'Meet'},
                {id:3, name: 'Activity'}
            ]);
        }
    }

    const showTimeMode = (currentMode) => {
        if(currentMode === 'startTime') {
            setShowStartTime(true);
        } else {
            setShowEndTime(true);
        }
    };

    useEffect(() => {
        async function getDBTeams() {
            const results = await fetchCoachTeams(userCtx.userId, token);
            setTeams(results);
        }
    
        getDBTeams();
    }, [token]);

    function submitHandler() {
        if(type==='Meet') {
            
        }
        // try {
        //     const eventData = 
        //         {
        //             teamId: userCtx.teamId,
        //             teamName: userCtx.teamName,
        //             date: date,
        //             type: type,
        //             location: location,
        //             startTime: startTime,
        //             endTime: endTime,
        //             insertDate: new Date()
        //         }
        //     postEvent(eventData, token);
        // } catch (error) {
        //     console.log(error);
        //     Alert.alert('Addition Failed', 'Failed to add event. Please try again later.')
        // }
    }

    return (
        <TouchableWithoutFeedback onPress={() =>{ Keyboard.dismiss(); }} >
        <KeyboardAvoidingView 
            behavior={Platform.OS === "ios" ? "padding" : "height"}>
        <ScrollView>
        <View style={styles.container}>
            <Text style={styles.headerText}>Add Event</Text>
            <SelectDropdown
                data={teams}
                onSelect={(selectedItem, index) => {
                    const teamData = {
                        name: selectedItem.name,
                        id: selectedItem.id
                    };
                    userCtx.switchTeam(teamData);
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
            <TouchableOpacity onPress={showDatepicker}>
                <View style={styles.lengthRow}>
                    <Text style={styles.formText}>Date: {format(date, "MMMM do, yyyy")}</Text>
                    <Ionicons name="calendar-outline" size={24} color="darkgreen" style={styles.iconStyle} />
                </View>
            </TouchableOpacity>
            {showDate && (
                <DateTimePicker
                    testID="datePicker"
                    value={date}
                    mode={'date'}
                    is24Hour={true}
                    onChange={onDateChange}
                />
            )}
            <View style={styles.lengthRow}>
                <Text>On Own?</Text>
                <CheckBox
                    checked={onOwn}
                    toggle={toggleOnOwn}
                />
            </View>
            <TouchableOpacity onPress={showStartTimepicker} disabled={onOwn}>
                <View style={styles.lengthRow}>
                    <Text style={styles.formText}>Start Time: {format(startTime, "h:mm a")}</Text>
                    <Ionicons name="time-outline" size={24} color="darkgreen" style={styles.iconStyle} />
                </View>
            </TouchableOpacity>
            {showStartTime && (
                <DateTimePicker
                    testID="startPicker"
                    value={startTime}
                    mode={'time'}
                    is24Hour={false}
                    onChange={onStartTimeChange}
                />
            )}
            <TouchableOpacity onPress={showEndTimepicker} disabled={onOwn}>
                <View style={styles.lengthRow}>
                    <Text style={styles.formText}>End Time: {format(endTime, "h:mm a")}</Text>
                    <Ionicons name="time-outline" size={24} color="darkgreen" style={styles.iconStyle} />
                </View>
            </TouchableOpacity>
            {showEndTime && (
                <DateTimePicker
                    testID="endPicker"
                    value={startTime}
                    mode={'time'}
                    is24Hour={false}
                    onChange={onEndTimeChange}
                />
            )}
            <UserInput
                label="Location:"
                value={location}
                onChangeText={setLoc}
                autoCorrect={false}
                editable={!onOwn}
            />
            <SelectDropdown
                data={types}
                onSelect={(selectedItem, index) => {
                    setType(selectedItem.name);
                }}
                defaultValueByIndex={0}
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
            {/* <UserInput
                label="Notes:"
                value={notes}
                onChangeText={setNotes}
                multiline   // ios starts top left
                textAlignVertical='top'  // Android starts top left
                numberOfLines={6}
                style={styles.notesInput}
            />
            <SelectDropdown
                data={athletes}
                onSelect={(selectedItem, index) => {
                    setTestID(selectedItem.id);
                }}
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
            />*/}
        <OurButton 
            buttonPressed={() => submitHandler()}
            buttonText="Submit"
            style={styles.button}
        />
        </View>
        </ScrollView>
        </KeyboardAvoidingView>
        </TouchableWithoutFeedback>
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
    button: {
        margin: 25,
        alignItems: 'center'
    }
});

export default AddEventScreen;