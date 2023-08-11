import React, { useContext, useEffect, useRef, useState } from 'react';
import { Alert, Keyboard, KeyboardAvoidingView, Modal, Platform, ScrollView, StyleSheet,
    Text, TouchableOpacity, TouchableWithoutFeedback, View } from 'react-native';
import SelectDropdown from 'react-native-select-dropdown';
import DateTimePicker from '@react-native-community/datetimepicker';
import { format } from 'date-fns';
import { putCalendar, postCalendarEvent } from '../../util/http';
import { UserContext } from '../../store/context/user-context';
import UserInput from '../../components/UserInput';
import OurButton from '../../components/OurButton';
import CheckBox from '../../components/CheckBox';
import Colors from '../../constants/ColorThemes';
import { Ionicons } from '@expo/vector-icons';

const AddCalendarScreen = ({ navigation }) => {
    var defaultDay = new Date();

    const userCtx = useContext(UserContext);      // App User Info
    const [calendarEventTitle, setCalendarEventTitle] = useState('');      // Name for Calendar Event
    const typeDropdownRef = useRef({});           // Event type drop down reference
    const [type, setType] = useState('Practice');   // Event Type
    const [types, setTypes] = useState([
        {id:0, name: 'Practice'},
        {id:1, name: 'Activity'},
        {id:2, name: 'Competition'}
    ]);
    const [date, setDate] = useState(defaultDay);         // Date of workout
    const [showDate, setShowDate] = useState(false);      // Show or Hide Date Picker
    const [onOwn, setOnOwn] = useState(false);            // If it's a solo task or not
    const [startTime, setStartTime] = useState(new Date());         // Time of workout
    const [showStartTime, setShowStartTime] = useState(false);      // Show or Hide Date Picker
    const [endTime, setEndTime] = useState(new Date());             // End time of workout
    const [showEndTime, setShowEndTime] = useState(false);          // Show or Hide Date Picker
    const [location, setLocation] = useState('');         // Location to meet
    const [infoLink, setInfoLink] = useState('');         // Link for additional info like schedule
    const [resultsLink, setResultsLink] = useState('');         // Link for results
    const [notes, setNotes] = useState('');       // Coaches notes if they have any
    const [attachment, setAttachment] = useState(''); // TODO
 
    // const [modalVisible, setModalVisible] = useState(false);


    // All these Data and time pickers were a hassle
    // Date Picker
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
    
    // Start Time Picker
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

    // End Time Picker
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
    
    const showTimeMode = (currentMode) => {
        if(currentMode === 'startTime') {
            setShowStartTime(true);
        } else {
            setShowEndTime(true);
        }
    };

    // On Own button limits User Input
    const toggleOnOwn = () => {
        setOnOwn(!onOwn);
        if(!onOwn) {
            setTypes([
                {id:0, name: 'Practice'},
                {id:1, name: 'Activity'}
            ]);

            if(type === 'Competition') {
                setType('Practice');
                typeDropdownRef.current.reset();
            }
        } else {
            setTypes([
                {id:0, name: 'Practice'},
                {id:1, name: 'Activity'},
                {id:2, name: 'Competition'}
            ]);
        }
    }

    function attachFileHandler() {
        Alert.alert('Sorry!', 'Not implemented yet');
    }

    async function submitHandler() {
        const calendarData = {
            teamId: userCtx.teamId,
            teamName: userCtx.teamName,
            date: format(date, "yyyy-MM-dd"),
            type: type,
            location: location,
            startTime: format(startTime, "h:mm a"),
            endTime: format(endTime, "h:mm a"),
            insertDate: new Date(),
            calendarEventTitle: calendarEventTitle,
            notes: notes,
            infoLink: infoLink,
            resultsLink: resultsLink,
            attachment: attachment
        }
        let newCalendarId = '';
        await postCalendarEvent(calendarData, userCtx.token)
        .then(function (response) {
            newCalendarId = response.data.name;
        })
        .catch(function (error) {
            console.log(error);
            return;
        });
        putCalendar(newCalendarId, userCtx.token)

        navigation.goBack();
    }


    // async function closeModal(action) {
    //     if (action === 'add') {
    //         var calendarId = '';
    //         const calendarData = {
    //             teamId: userCtx.teamId,
    //             teamName: userCtx.teamName,
    //             date: format(date, "yyyy-MM-dd"),
    //             type: type,
    //             location: location,
    //             startTime: format(startTime, "h:mm a"),
    //             endTime: format(endTime, "h:mm a"),
    //             insertDate: new Date()
    //         }
    //         await postCalendar(calendarData, token)
    //         .then(function (response) {
    //             calendarId = response.data.name;
    //         })
    //         .catch(function (error) {
    //             console.log(error);
    //         });

    //     }
    //     setModalVisible(!modalVisible);
    // }

    return (
        <TouchableWithoutFeedback onPress={() =>{ Keyboard.dismiss(); }} >
        <KeyboardAvoidingView 
            behavior={Platform.OS === "ios" ? "padding" : "height"}>
        <ScrollView>
        <View style={styles.container}>
            {showDate && (
                <DateTimePicker
                    testID="datePicker"
                    value={date}
                    mode={'date'}
                    is24Hour={true}
                    onChange={onDateChange}
                />
            )}
            {showStartTime && (
                <DateTimePicker
                    testID="startPicker"
                    value={startTime}
                    mode={'time'}
                    is24Hour={false}
                    onChange={onStartTimeChange}
                />
            )}
            {showEndTime && (
                <DateTimePicker
                    testID="endPicker"
                    value={startTime}
                    mode={'time'}
                    is24Hour={false}
                    onChange={onEndTimeChange}
                />
            )}
            {/* <Modal
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
                        <Text style={styles.modalText}>{type} Notes</Text>
                        <UserInput
                            label="Notes:"
                            value={notes}
                            onChangeText={setNotes}
                            multiline   // ios starts top left
                            textAlignVertical='top'  // Android starts top left
                            numberOfLines={6}
                            style={styles.notesInput}
                        />
                        <UserInput
                            label="Link"
                            value={link}
                            onChangeText={setLink}
                            keyboardType="url"
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
            </Modal> */}
            <Text style={styles.teamText}>Team: {userCtx.teamName}</Text>
            <UserInput
                label="Title"
                value={calendarEventTitle}
                onChangeText={setCalendarEventTitle}
            />
            <SelectDropdown
                data={types}
                ref={typeDropdownRef}  
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
            <TouchableOpacity onPress={showDatepicker}>
                <View style={styles.lengthRow}>
                    <Text style={styles.formText}>Date: {format(date, "MMMM do, yyyy")}</Text>
                    <Ionicons name="calendar-outline" size={24} color="darkgreen" style={styles.iconStyle} />
                </View>
            </TouchableOpacity>
            <View style={styles.lengthRow}>
                <Text>On Own?</Text>
                <CheckBox
                    checked={onOwn}
                    toggle={toggleOnOwn}
                />
            </View>
            {onOwn ?
                <View>
                    <View style={styles.lengthRow}>
                        <Text style={styles.disabledText}>Start Time: On Own</Text>
                    </View>
                    <View style={styles.lengthRow}>
                        <Text style={styles.disabledText}>End Time: On Own</Text>
                    </View>
                    <View style={styles.userInput}>
                        <UserInput
                            label="Location:"
                            value={"On Own"}
                            editable={false}
                        />
                    </View>
                </View>
            :
                <View>
                    <TouchableOpacity onPress={showStartTimepicker} disabled={onOwn}>
                        <View style={styles.lengthRow}>
                            <Text style={styles.formText}>Start Time: {format(startTime, "h:mm a")}</Text>
                            <Ionicons name="time-outline" size={24} color="darkgreen" style={styles.iconStyle} />
                        </View>
                    </TouchableOpacity>
                    <TouchableOpacity onPress={showEndTimepicker} disabled={onOwn}>
                        <View style={styles.lengthRow}>
                            <Text style={styles.formText}>End Time: {format(endTime, "h:mm a")}</Text>
                            <Ionicons name="time-outline" size={24} color="darkgreen" style={styles.iconStyle} />
                        </View>
                    </TouchableOpacity>
                    <View style={styles.userInput}>
                        <UserInput
                            label="Location:"
                            value={location}
                            onChangeText={setLocation}
                            autoCorrect={false}
                            editable={!onOwn}
                        />
                    </View>
                </View>
            }
            <UserInput
                label="Info Link"
                value={infoLink}
                onChangeText={setInfoLink}
                keyboardType="url"
            />
            <UserInput
                label="Results Link"
                value={resultsLink}
                onChangeText={setResultsLink}
                keyboardType="url"
            />
            <TouchableOpacity onPress={() => attachFileHandler()} >
                <Text>Attach File</Text>
            </TouchableOpacity>
            <UserInput
                label="Notes:"
                value={notes}
                onChangeText={setNotes}
                multiline   // ios starts top left
                textAlignVertical='top'  // Android starts top left
                numberOfLines={6}
                style={styles.notesInput}
            />
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
        paddingVertical: 25,
        alignItems: 'center'
    },
    teamText: {
        paddingHorizontal: 40,
        fontSize: 22,
        color: 'darkgreen',
        fontWeight: 'bold'
    },
    selectDropDownButton: {
        width: '80%',
        height: 40,
        marginVertical: 15,
        backgroundColor: 'darkgreen',
        borderRadius: 8,
        alignSelf: 'center',
        alignContent: 'center'
    },
    selectDropDown: {
        backgroundColor: 'darkgreen',
        borderBottomLeftRadius: 12,
        borderBottomRightRadius: 12,
    },
    selectDropDownRow: {
        backgroundColor: 'darkgreen', 
        borderBottomColor: '#C5C5C5',
    },
    selectDropDownText: {
        color: '#FFF',
        textAlign: 'center',
        fontWeight: 'bold'
    },
    lengthRow: {
        flexDirection: 'row',
        marginLeft: '10%',
        paddingVertical: 8,
        alignItems: 'center'
    },
    formText: {
        fontSize: 22,
        textAlign: 'center',
        color: 'darkgreen'
    },
    disabledText: {
        fontSize: 22,
        textAlign: 'center',
        color: 'gray'
    },
    userInput: {
        alignItems: 'center'
    },
    notesInput: {
        height: 150,
        borderRadius: 8,
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
    },
    viewRow: {
        flexDirection: 'row',
        justifyContent: 'space-between',
    },
    iconStyle: {
        paddingHorizontal: 15
    },
    button: {
        margin: 25,
        alignItems: 'center',
        alignSelf: 'center'
    }
});

export default AddCalendarScreen;