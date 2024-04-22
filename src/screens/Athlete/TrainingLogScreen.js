import React, { useContext, useEffect, useState } from 'react';
import { Alert, Keyboard, KeyboardAvoidingView, ScrollView, StyleSheet, Text, TouchableOpacity, TouchableWithoutFeedback, View } from 'react-native';
import { Ionicons } from '@expo/vector-icons';
import SelectDropdown from 'react-native-select-dropdown';
import DateTimePicker from '@react-native-community/datetimepicker';
import { format } from 'date-fns';
import { fetchEquipment, patchEquipment, postCardioLog } from '../../util/http';
import { UserContext } from '../../store/context/user-context';
import UserInput from '../../components/UserInput';
import OurButton from '../../components/OurButton';
import Colors from '../../constants/ColorThemes';

const TrainingLogScreen = ( ) => {
    const userCtx = useContext(UserContext);      // App User Info
    const token = userCtx.token;                  // User Auth Token
    const [date, setDate] = useState(new Date()); // Date of workout
    const [mode, setMode] = useState('date');     // Date picker mode
    const [show, setShow] = useState(false);      // Show or Hide Date Picker
    const [time, setTime] = useState(0);          // Time workout took
    const [distance, setDist] = useState(0);      // Distance travelled during workout
    const [unit, setUnit] = useState('mi');
    const [route, setRoute] = useState('');
    const [notes, setNotes] = useState('');       // Workout notes
    const [feel, setFeel] = useState('');          // Users workout feel
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

    const units = [
        { id: 0, name: 'mi'},
        { id: 1, name: 'km'}
    ];

    useEffect(() => {
        async function getEquipment() {
            const dbEquipment = await fetchEquipment(userCtx.userId, token);
            const holdEquipmentObj = [];

            for (const key in dbEquipment.data) {
                if(dbEquipment.data[key].status === 'A') {
                    const equipObj = {
                        id: key,
                        name: dbEquipment.data[key].equipName,
                        distance: dbEquipment.data[key].distance
                    };
                    holdEquipmentObj.push(equipObj);
                }
            }
            setEquipmentList(holdEquipmentObj);
        }
    
        getEquipment();
    }, [token]);

    function submitHandler() {
        try {
            const cardioData = 
                {
                    uid: userCtx.userId,
                    equipment: equipment.id,
                    distance: distance,
                    notes: notes,
                    date: format(date, "yyyy-MM-dd"),
                    duration: time,
                    feel: feel
                }

            postCardioLog(cardioData, token);
            
            let convertedDist = 0;
            if(unit === 'mi') {
                convertedDist = parseInt(distance) * 1609;
            } else {
                convertedDist = parseInt(distance) * 1000;
            }
            const totalDistance = convertedDist + parseInt(equipment.distance);
            const patchDistance = { distance: totalDistance };
            patchEquipment(equipment.id, patchDistance);

            clearScreen();
        } catch (error) {
            console.log(error);
            Alert.alert('Addition Failed', 'Failed to add workout. Please try again later.')
        }
    }

    function clearScreen() {
        setNotes('');
        setDist('0');
        setTime('0');
        setFeel('');
        setRoute('');
    }

    return (
        <TouchableWithoutFeedback onPress={() =>{ Keyboard.dismiss(); }} >
        <KeyboardAvoidingView 
            behavior={Platform.OS === "ios" ? "padding" : "height"}>
        <ScrollView>
        <View style={styles.container}>
            <Text style={styles.headerText}>Training Log</Text>
            <View style={styles.lengthRow}>
                <TouchableOpacity onPress={showDatepicker}>
                    <View style={styles.lengthRow}>
                        <Text style={styles.formText}>Date: {format(date, "MMMM do, yyyy")}</Text>
                        <Ionicons name="calendar-outline" size={24} color="darkgreen" style={styles.iconStyle} />
                    </View>
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
            <UserInput
                label="Duration:"
                value={time}
                onChangeText={setTime}
                keyboardType='numeric'
                autoCorrect={false}
                maxLength={8}
                placeholder="hh:mm:ss"
            />
            <View style={styles.lengthRow}>
                <UserInput
                    label="Length:"
                    value={distance}
                    onChangeText={setDist}
                    keyboardType='numeric'
                    autoCorrect={false}
                    maxLength={7}
                />
                <SelectDropdown 
                    data={units}
                    onSelect={(selectedItem, index) => {
                        setUnit(selectedItem.name);
                    }}
                    defaultButtonText="mi"
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
            </View>
            <SelectDropdown 
                data={equipmentList}
                onSelect={(selectedItem, index) => {
                    setEquipment(selectedItem);
                    console.log(selectedItem, index)
                }}
                defaultButtonText="Select Equipment"
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
            <UserInput
                label="Route:"
                value={route}
                onChangeText={setRoute}
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
                <TouchableOpacity onPress={() => setFeel('1')}>
                    <View style={[styles.feelButton, feel==='1' ? {backgroundColor: 'green'} : {backgroundColor: 'orange'}]}>
                        <Text style={styles.feelText}>1</Text>
                    </View>
                </TouchableOpacity>
                <TouchableOpacity onPress={() => setFeel('2')}>
                    <View style={[styles.feelButton, feel==='2' ? {backgroundColor: 'green'} : {backgroundColor: 'orange'}]}>
                        <Text style={styles.feelText}>2</Text>
                    </View>
                </TouchableOpacity>
                <TouchableOpacity onPress={() => setFeel('3')}>
                    <View style={[styles.feelButton, feel==='3' ? {backgroundColor: 'green'} : {backgroundColor: 'orange'}]}>
                        <Text style={styles.feelText}>3</Text>
                    </View>
                </TouchableOpacity>
                <TouchableOpacity onPress={() => setFeel('4')}>
                    <View style={[styles.feelButton, feel==='4' ? {backgroundColor: 'green'} : {backgroundColor: 'orange'}]}>
                        <Text style={styles.feelText}>4</Text>
                    </View>
                </TouchableOpacity>
                <TouchableOpacity onPress={() => setFeel('5')}>
                    <View style={[styles.feelButton, feel==='5' ? {backgroundColor: 'green'} : {backgroundColor: 'orange'}]}>
                        <Text style={styles.feelText}>5</Text>
                    </View>
                </TouchableOpacity>
            </View>
            <View style={styles.lengthRow}>
                <OurButton 
                    buttonPressed={() => submitHandler()}
                    buttonText="Submit"
                />
            </View>
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
    lengthRow: {
        flexDirection: 'row',
        padding: 10,
        width: '100%',
        justifyContent: 'space-evenly',
        alignItems: 'center'
    },
    formText: {
        fontSize: 22,
        textAlign: 'center',
        color: 'darkgreen'
    },
    text: {
        fontSize: 18,
        textAlign: 'center',
        textAlignVertical: 'center'
    },
    selectDropDownButton: {
        width: '80%',
        height: 50,
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
    notesInput: {
        borderRadius: 8
    },
    iconStyle: {
        paddingHorizontal: 15
    },
    feelButton: {
        width: 55,
        height: 55,
        justifyContent: 'center',
        alignItems: 'center',
        padding: 10,
        borderRadius: 100
    },
    feelText: {
        fontSize: 22,
        fontWeight: 'bold'
    }
});

export default TrainingLogScreen;