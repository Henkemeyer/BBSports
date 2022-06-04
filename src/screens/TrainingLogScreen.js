import React, { useContext, useEffect, useState } from 'react';
import { Alert, Keyboard, KeyboardAvoidingView, StyleSheet, Text, TouchableOpacity, TouchableWithoutFeedback, View } from 'react-native';
import SelectDropdown from 'react-native-select-dropdown';
import DateTimePicker from '@react-native-community/datetimepicker';
import { fetchEquipment, postCardio } from '../util/http';
import { formatDate } from '../util/date';
import { UserContext } from '../store/context/user-context';
import UserInput from '../components/UserInput';
import OurButton from '../components/OurButton';
import Colors from '../constants/ColorThemes';

const TrainingLogScreen = ( ) => {
    const userCtx = useContext(UserContext);      // App User Info
    const token = userCtx.token;                  // User Auth Token
    const [date, setDate] = useState(new Date()); // Date of workout
    const [mode, setMode] = useState('date');     // Date picker mode
    const [show, setShow] = useState(false);      // Show or Hide Date Picker
    const [time, setTime] = useState(0);          // Time workout took
    const [getDist, setDist] = useState(0);       // Distance travelled during workout
    const [getNotes, setNotes] = useState('');    // Workout notes
    const [equipmentList, setEquipmentList] = useState([]); // List of users equipment (shoes, wheels, bikes)
    const [equipment, setEquipment] = useState('');         // Equipment used for workout
  
    const onChange = (event, selectedDate) => {
      const currentDate = selectedDate;
      setShow(false);
      setDate(currentDate);
    };
  
    const showMode = (currentMode) => {
      setShow(true);
      setMode(currentMode);
    };
  
    const showDatepicker = () => {
      showMode('date');
    };

    useEffect(() => {
        async function getEquipment() {
            const dbEquipment = await fetchEquipment(userCtx.userId, token);
            setEquipmentList(dbEquipment);
        }
    
        getEquipment();
    }, [token]);

    function submitHandler() {
        try {
            const cardioData = 
                {
                    uid: userCtx.userId,
                    equipment: equipment,
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
        setTime(0);
    }

    return (
        <View style={styles.container}>
            <Text style={styles.headerText}>Training Log</Text>
            <View style={styles.lengthRow}>
                <TouchableOpacity onPress={showDatepicker}>
                    <Text style={styles.headerText}>Date: {formatDate(date)}</Text>
                </TouchableOpacity>
                {show && (
                    <DateTimePicker
                        testID="dateTimePicker"
                        value={date}
                        mode={mode}
                        is24Hour={true}
                        onChange={onChange}
                    />
                )}
            </View>
            <TouchableWithoutFeedback onPress={() =>{ Keyboard.dismiss(); }} >
                <KeyboardAvoidingView behavior='position'>
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
                        <Text>Units</Text>
                    </View>
                    <View style={styles.lengthRow}>
                        <Text style={styles.text}>Equipment:</Text>
                        <SelectDropdown 
                            data={equipmentList}
                            onSelect={(selectedItem, index) => {
                                setEquipment(selectedItem);
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
                        label="Notes:"
                        onChangeText={setNotes}
                        multiline
                        numberOfLines={6}
                        style={styles.notesInput}
                    />
                    <View style={styles.lengthRow}>
                        <OurButton 
                            buttonPressed={() => submitHandler()}
                            buttonText="Submit"
                        />
                    </View>
                    
                </KeyboardAvoidingView>
            </TouchableWithoutFeedback>
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        paddingVertical: 30,
        paddingHorizontal: 10
    },
    headerText: {
        paddingTop: 25,
        fontSize: 30,
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
    text: {
        fontSize: 18,
        textAlign: 'center',
        textAlignVertical: 'center'
    },
    notesInput: {
        height: 150,
        borderRadius: 8
    }
});

export default TrainingLogScreen;