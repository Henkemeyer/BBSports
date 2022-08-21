import React, { useContext, useEffect, useState } from 'react';
import { Alert, Keyboard, KeyboardAvoidingView, StyleSheet, Text, TouchableOpacity, TouchableWithoutFeedback, View } from 'react-native';
import SelectDropdown from 'react-native-select-dropdown';
import DateTimePicker from '@react-native-community/datetimepicker';
import { format } from 'date-fns';
import { fetchAthleteGroup, fetchCoachTeams, postCardio } from '../util/http';
import { UserContext } from '../store/context/user-context';
import UserInput from '../components/UserInput';
import OurButton from '../components/OurButton';
import Colors from '../constants/ColorThemes';
import { Ionicons } from '@expo/vector-icons';

const CoachCardioScreen = ( ) => {
    const userCtx = useContext(UserContext);      // App User Info
    const token = userCtx.token;                  // User Auth Token
    const [teams, setTeams] = useState([]);       // List of Coach's Teams
    const [date, setDate] = useState(new Date()); // Date of workout
    const [mode, setMode] = useState('date');     // Date picker mode
    const [show, setShow] = useState(false);      // Show or Hide Date Picker
    const [time, setTime] = useState(new Date());          // Time workout took
    const [getDist, setDist] = useState(0);       // Distance travelled during workout
    const [getNotes, setNotes] = useState('');    // Workout notes
    const [groupList, setgroupList] = useState([]); // List of users groups
    const [group, setGroup] = useState('');         // Group used for workout
  
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

    useEffect(() => {
        async function getDBTeams() {
            const results = await fetchCoachTeams(userCtx.userId, token);
            setTeams(results);
        }
    
        getDBTeams();
    }, [token]);

    useEffect(() => {
        async function getGroup() {
            const dbGroup = 'placeholder'; //await fetchAthleteGroup(userCtx.userId, token);
            setgroupList(dbGroup);
        }
    
        getGroup();
    }, [userCtx.team.id]);

    function submitHandler() {
        try {
            const cardioData = 
                {
                    uid: userCtx.userId,
                    group: group,
                    distance: getDist,
                    notes: getNotes,
                    date: date,
                    duration: time
                }

            postCardio(cardioData, token);
            clearScreen();
        } catch (error) {
            console.log(error);
            Alert.alert('Addition Failed', 'Failed to add workout. Please try again later.')
        }
    }

    function clearScreen() {
        setNotes('');
        setDist('');
        // setTime(0);
    }

    return (
        <TouchableWithoutFeedback onPress={() =>{ Keyboard.dismiss(); }} >
        <KeyboardAvoidingView behavior='position'>
        <View style={styles.container}>
            <Text style={styles.headerText}>Cardio Workouts</Text>
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
                defaultButtonText={userCtx.team.name}
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
            {/* <View style={styles.lengthRow}>
                <Text style={styles.formText}>Group:</Text>
                <SelectDropdown 
                    data={groupList}
                    onSelect={(selectedItem, index) => {
                        setGroup(selectedItem);
                        console.log(selectedItem, index)
                    }}
                    buttonTextAfterSelection={(selectedItem, index) => {
                        // text represented after item is selected
                        // if data array is an array of objects then return selectedItem.property to render after item is selected
                        return selectedItem.name
                    }}
                    rowTextForSelection={(item, index) => {
                        return item.name
                    }}
                />
            </View>
            <UserInput
                label="Duration:"
                onChangeText={setTime}
                keyboardType='numeric'
                autoCorrect={false}
                maxLength={8}
                placeholder="hh:mm:ss"
            />
            <View style={styles.lengthRow}>
                <UserInput
                    label="Length:"
                    onChangeText={setDist}
                    keyboardType='numeric'
                    autoCorrect={false}
                    maxLength={7}
                    style={{width: 275}}
                />
                <Text style={styles.formText}>Units</Text>
            </View> */}
            <UserInput
                label="Workout:"
                onChangeText={setNotes}
                multiline
                numberOfLines={6}
                style={styles.notesInput}
            />
            <OurButton 
                buttonPressed={() => submitHandler()}
                buttonText="Submit"
            />
        </View>
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
        fontSize: 24,
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
        borderRadius: 8,
        elevation: 4,
        shadowColor: 'darkgreen',
        shadowOpacity: 0.25,
        shadowOffset: {width: 0, height: 2 },
        shadowRadius: 8
    },
    iconStyle: {
        paddingHorizontal: 15
    }
});

export default CoachCardioScreen;