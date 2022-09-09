import React, { useContext, useEffect, useRef, useState} from 'react';
import { StyleSheet, Text, TextInput, TouchableWithoutFeedback, View } from 'react-native';
import OurButton from '../components/OurButton';
import Events from '../constants/Events';
import { fetchRoster, fetchTeam } from '../util/http';
import { UserContext } from '../store/context/user-context';
import SelectDropdown from 'react-native-select-dropdown';
import MultiSelect from 'react-native-multiple-select';
import { Ionicons } from '@expo/vector-icons';
import CheckBox from '../components/CheckBox';

const StopwatchSetupScreen = ({ navigation }) => {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [sport, setSport] = useState('')
    const [level, setLevel] = useState('')
    const [sex, setSex] = useState('')
    const multiSelectRef = useRef({});
    const [athletes, setAthletes] = useState([])
    const [search, setSearch] = useState('')
    const [selectedAthletes, setSelectedAthletes] = useState([])
    const [eventsList, setEventsList] = useState([])
    const [eventId, setEventId] = useState('')
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

    function selectEventHandler(event) {
        console.log("You still have to implement this you fucking nerd")
    }

    return(
        <TouchableWithoutFeedback onPress={() =>{ Keyboard.dismiss(); }} >
        <View style={styles.container}>
            <View style={{alignItems: 'center'}}>
                <Text>Record Race</Text>
                <Text>{userCtx.teamName}</Text>
                <SelectDropdown
                    data={eventsList}
                    onSelect={(selectedItem, index) => {
                        selectEventHandler(selectedItem);
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
            </View>
            <MultiSelect
                hideTags
                items={athletes}
                uniqueKey="id"
                ref={multiSelectRef}
                onSelectedItemsChange={(selectedItems) => setSelectedAthletes(selectedItems)}
                selectedItems={selectedAthletes}
                selectText="Pick Athletes"
                searchInputPlaceholderText="Search Athletes..."
                onChangeInput={ (text)=> console.log(text)}
                // altFontFamily="ProximaNova-Light"
                tagRemoveIconColor="#CCC"
                tagBorderColor="#CCC"
                tagTextColor="#CCC"
                selectedItemTextColor="darkgreen"
                selectedItemIconColor="darkgreen"
                itemTextColor="#000"
                displayKey="name"
                searchInputStyle={{ color: '#CCC' }}
                submitButtonColor="darkgreen"
                submitButtonText="Submit"
            />
        </View>
        </TouchableWithoutFeedback>
    );
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        // alignItems: 'center',
        backgroundColor: 'linen',
        marginVertical: 25
    },
    counter: {
        fontSize: 60,
        textAlign: 'center',
        borderWidth: 1,
        borderRadius: 8,
        borderColor: 'black',
        backgroundColor: '#FFFFFF',
        margin: 20,
        paddingHorizontal: 7
    },
    miniCounter: {
        fontSize:20,
        position: 'relative',
        top: -32,
        right: -50
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
    athletes: {
        paddingVertical: 15,
    },
    swButton: {
        width: '25%',
    }
});


export default StopwatchSetupScreen;