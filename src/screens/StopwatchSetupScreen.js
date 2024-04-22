import React, { useContext, useEffect, useRef, useState} from 'react';
import { Alert, Keyboard, KeyboardAvoidingView, StyleSheet, Text, TextInput, TouchableWithoutFeedback, View } from 'react-native';
import OurButton from '../components/OurButton';
import Events from '../constants/Events';
import { fetchRoster, fetchTeam, fetchTeamCalendar } from '../util/http';
import { UserContext } from '../store/context/user-context';
import SelectDropdown from 'react-native-select-dropdown';
import OurDropDownSelect from '../components/OurDropDownSelect';
import { Ionicons } from '@expo/vector-icons';
import { format } from 'date-fns';

const StopwatchSetupScreen = ({ navigation }) => {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [sport, setSport] = useState('')
    const [level, setLevel] = useState('')
    const [sex, setSex] = useState('')

    const [meetList, setMeetList] = useState([])
    const [meet, setMeet] = useState('')
    const [meetError, setMeetError] = useState('')
    
    const [eventsList, setEventsList] = useState([])
    const [event, setEvent] = useState('')

    const multiSelectRef = useRef({});
    const [athletes, setAthletes] = useState([])
    const [search, setSearch] = useState('')
    const [selectedAthletes, setSelectedAthletes] = useState([])

    const [splits, setSplits] = useState(1)
    const [alternating, setAlternating] = useState(false) // Track ex: 200, 600 vs 400, 800

    useEffect(() => {
        async function initializeValues() {
            // const teamData = await fetchTeam(userCtx.teamId, token);

            // setSport(teamData.data.sport)
            // setLevel(teamData.data.level)
            // setSex(teamData.data.sex)
            setSport("Cross Country")
            setLevel("College")
            setSex(teamData.data.sex)
            let sportAbb = ''
            switch(sport) {
                case 'Cross Country':
                    sportAbb = 'XC';
                    break;
                case 'Track & Field':
                    sportAbb = 'TF';
                    break;
                case 'Gymnastics':
                    sportAbb = 'GYM';
                    break;
                case 'Basketball':
                    sportAbb = 'BB';
                    break;
                case 'Football':
                    sportAbb = 'FB';
                    break;
                default:
                    sportAbb = sport;
            }

            const eventStr = 'MCollegeXC' // sex+level+sport
            setEventsList(Events.MCollegeXC)

            // const dbMeets = await fetchTeamCalendar(userCtx.teamId, token);
            const meetsArr = [];
            const today = format(new Date(), 'yyyy-MM-dd')

            for (const key in dbMeets.data) {
                if(dbMeets.data[key].date !== today) {
                    continue;
                }
                if(dbMeets.data[key].type !== 'Meet' && dbMeets.data[key].type !== 'Game') {
                    continue;
                }

                const tmpArr = {
                    id: key,
                    name: dbMeets.data[key].description,
                    type: dbMeets.data[key].type
                }
                meetsArr.push(tmpArr)
            }
            setMeetList([...meetsArr]);
            if(!meetList || meetList.length === 0) {
                setMeetError("Nothing scheduled for today to time.")
            }
            
            const dbAthletes = await fetchRoster(userCtx.teamId, token);
            const rosterArr = [];

            for (const key in dbAthletes.data) {
                if(dbAthletes.data[key].status !== 'A') {
                    continue;
                }

                const athArr = {
                    id: key,
                    name: dbAthletes.data[key].fullName,
                    uid: dbAthletes.data[key].uid
                }
                rosterArr.push(athArr)
            }
            setAthletes([...rosterArr]);
        }

        initializeValues();
    }, [userCtx.teamId]);

    function selectMeetHandler(meet) {
        console.log("TODO")
    }

    function selectEventHandler(event) {
        console.log("TODO")
    }

    const submitForm = () => {
        if(selectedAthletes.length === 0) {
            Alert.alert("No Selection", "No Athletes selected. Select at least one to continue.")
        } else {
            const selAthArr = []
            for(const i in selectedAthletes) {
                const athObj = athletes.find(athlete => {
                    return athlete.id === selectedAthletes[i]
                })
                selAthArr.push(athObj)
            }

            if (sport === "Cross Country") {
                navigation.navigate("XCTimer", {
                    meet: meet,
                    event: event,
                    numSplits: splits,
                    athletes: selAthArr
                })
            }
        }
    }

    return(
        <TouchableWithoutFeedback onPress={() =>{ Keyboard.dismiss(); }} >
        <View style={styles.container}>
            <Text style={styles.title}>Record</Text>
            <Text style={styles.header}>{userCtx.teamName}</Text>
            <SelectDropdown
                data={meetList}
                disabled={meetList.length===0 ? true : false}
                onSelect={(selectedItem, index) => {
                    setMeet(selectedItem);
                }}
                defaultButtonText={meetList.length===0 ? "Nothing Scheduled" : "Select a Meet"}
                defaultValueByIndex={0}
                buttonTextAfterSelection={(selectedItem, index) => {
                    return selectedItem.name
                }}
                rowTextForSelection={(item, index) => {
                    return item.name
                }}
                buttonStyle={meetList.length===0 ? styles.disabledDropDownButton : styles.selectDropDownButton}
                buttonTextStyle={styles.selectDropDownText}
                renderDropdownIcon={isOpened => {
                    return <Ionicons name={isOpened ? 'chevron-up-circle-sharp' : 'chevron-down-circle-outline'} color={'#FFF'} size={18} />;
                }}
                dropdownIconPosition={'right'}
                dropdownStyle={styles.selectDropDown}
                rowStyle={styles.selectDropDownRow}
                rowTextStyle={styles.selectDropDownText}
            />
            <SelectDropdown
                data={eventsList}
                onSelect={(selectedItem, index) => {
                    setEvent(selectedItem);
                }}
                defaultButtonText="Select an Event"
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
            <View style={styles.viewRow}>
                <Text style = {styles.header}>Num of Splits: </Text>
                <TextInput
                    value={splits}
                    onChangeText={(text) => {
                        const value = text.replace(/[^0-9]/g, '')
                        setSplits(value)
                    }}
                    keyboardType="numeric"
                    maxLength={2}
                    placeholder='1'
                    placeholderTextColor={'red'}
                    style={styles.inputContainer}
                />
            </View>
            <OurDropDownSelect
                items={athletes}
                // ref={multiSelectRef}
                onItemsChange={setSelectedAthletes}
                selectedItems={selectedAthletes}
                itemName="Athletes"
            />
            <View style={{alignItems: 'center'}}>
                <OurButton
                    buttonText="Submit"
                    buttonPressed={submitForm}
                />
            </View>
        </View>
        </TouchableWithoutFeedback>
    );
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        justifyContent: 'space-evenly',
        backgroundColor: 'F4F4F4'
    },
    title: {
        fontSize: 24,
        fontWeight: 'bold',
        color: 'darkgreen',
        alignSelf: 'center'
    },
    header: {
        fontSize: 21,
        fontWeight: 'bold',
        color: 'darkgreen',
        alignSelf: 'center'
    },
    viewRow: {
        flexDirection: 'row',
        alignContent: 'center',
        alignSelf: 'center'
    },
    selectDropDownButton: {
        width: '80%',
        height: 50,
        backgroundColor: 'darkgreen',
        borderRadius: 8,
        alignSelf: 'center'
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
    inputContainer: {
        backgroundColor: 'white',
        borderBottomWidth: 1,
        borderColor: 'darkgreen',
        margin:10,
        padding:5,
        borderRadius:8,
        textAlign: 'center'
    },
    athletes: {
        paddingVertical: 15,
    },
    swButton: {
        width: '25%',
    },
    disabledDropDownButton: {
        width: '80%',
        height: 50,
        backgroundColor: 'darkgray',
        borderRadius: 8,
        alignSelf: 'center'
    }
});


export default StopwatchSetupScreen;