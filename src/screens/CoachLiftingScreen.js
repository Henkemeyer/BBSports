import React, { useContext, useEffect, useState } from 'react';
import { Alert, Keyboard, KeyboardAvoidingView, StyleSheet, Text, TouchableOpacity, TouchableWithoutFeedback, View } from 'react-native';
import { UserContext } from '../store/context/user-context';
import SelectDropdown from 'react-native-select-dropdown';
import DateTimePicker from '@react-native-community/datetimepicker';
import { Ionicons } from '@expo/vector-icons';
import { format } from 'date-fns';

const CoachLiftingScreen = () => {
    const userCtx = useContext(UserContext);      // App User Info
    const token = userCtx.token;                  // User Auth Token
    const [date, setDate] = useState(new Date()); // Date of workout
    const [mode, setMode] = useState('date');     // Date picker mode
    const [show, setShow] = useState(false);      // Show or Hide Date Picker
    const [time, setTime] = useState(new Date()); // Time of workout

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

    return (
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
            <Text>Custom list Comp:</Text>
            <View style={styles.header}>
                <Text style={styles.headerText}>Set</Text>
                <Text style={styles.headerText}>Lift</Text>
                <Text style={styles.headerText}>Amount</Text>
                <Text style={styles.headerText}>Unit</Text>
                <Text style={styles.headerText}>Reps</Text>
            </View>
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        margin: 20,
        paddingTop: 10
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
    }
    
});

export default CoachLiftingScreen;