import React, { useContext, useEffect, useRef, useState} from 'react';
import { Alert,  Keyboard, KeyboardAvoidingView ,StyleSheet, Text, TouchableWithoutFeedback, View } from 'react-native';
import OurButton from '../components/OurButton';
import Events from '../constants/Events';
import { fetchRoster, fetchTeam, fetchTeamEvents } from '../util/http';
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
    
    const [eventsList, setEventsList] = useState([])
    const [event, setEvent] = useState('')

    const multiSelectRef = useRef({});
    const [athletes, setAthletes] = useState([])
    const [search, setSearch] = useState('')
    const [selectedAthletes, setSelectedAthletes] = useState([])

    const [splits, setSplits] = useState(0)
    const [alternating, setAlternating] = useState(false) // Track ex: 200, 600 vs 400, 800

    useEffect(() => {
        async function initializeValues() {
            const teamData = await fetchTeam(userCtx.teamId, token);

            setSport(teamData.data.sport)
            setLevel(teamData.data.level)
            setSex(teamData.data.sex)
            let abbSport = ''
            switch(sport) {
                case 'Cross Country':
                    abbSport = 'XC';
                    break;
                case 'Track & Field':
                    abbSport = 'TF';
                    break;
                case 'Gymnastics':
                    abbSport = 'GYM';
                    break;
                case 'Basketball':
                    abbSport = 'BB';
                    break;
                case 'Football':
                    abbSport = 'FB';
                    break;
                default:
                    abbSport = sport;
            }

            const eventStr = 'MCollegeXC' // sex+level+abbSport
            setEventsList(Events.MCollegeXC)

            const dbMeets = await fetchTeamEvents(userCtx.teamId, token);
            const meetsArr = [];
            const today = format(new Date(), 'yyyy-MM-dd')

            for (const key in dbMeets.data) {
                if(dbMeets.data[key].date !== today) {
                    continue;
                }
                if(dbMeets.data[key].type === 'Activity' || dbMeets.data[key].type === 'Weights') {
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
        console.log("You still have to implement this you fucking geek")
    }

    function selectEventHandler(event) {
        console.log("You still have to implement this you fucking nerd")
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
                onSelect={(selectedItem, index) => {
                    setMeet(selectedItem);
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
            <SelectDropdown
                data={eventsList}
                onSelect={(selectedItem, index) => {
                    setEvent(selectedItem);
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
        backgroundColor: 'linen'
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
        paddingTop: 20,
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
    athletes: {
        paddingVertical: 15,
    },
    swButton: {
        width: '25%',
    }
});


export default StopwatchSetupScreen;