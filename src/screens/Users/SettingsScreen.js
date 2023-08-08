import React, { useContext, useEffect, useState  } from 'react';
import { Alert, ScrollView, StyleSheet, Text, View} from 'react-native';
import SelectDropdown from 'react-native-select-dropdown';
import OurButton from '../../components/OurButton';
import ShadowBox from '../../components/ShadowBox';
import { fetchTeam, fetchTeamsByAthlete, fetchTeamsByCoach } from '../../util/http';
import { UserContext } from '../../store/context/user-context';
import { Ionicons } from '@expo/vector-icons';

function SettingsScreen ({navigation}) {
    const userCtx = useContext(UserContext);
    const userId = userCtx.userId;
    const userMode = userCtx.userMode;
    const [teams, setTeams] = useState([]);

    useEffect(() => {
        async function getDBTeams() {
            let dbTeams = '';
            
            try {
                if(userMode === 'Athlete'){
                    dbTeams = await fetchTeamsByAthlete(userId, userCtx.token);
                } else if(userMode === 'Coach') {
                    dbTeams = await fetchTeamsByCoach(userId, userCtx.token);
                }
            } catch (error) {
                Alert.alert('Team Fetch Failed!', 'Failed to fetch teams. '+error)
            }
            
            let teamArr = [];
            console.log(dbTeams.data);
            for (const key in dbTeams.data) {
                if(dbTeams.data[key].status === "A") {
                    teamArr.push([key,dbTeams.data[key].teamName]);
                }
            }
            setTeams(teamArr);
            console.log(teams);
        }
        getDBTeams();
    }, [userMode]);

    function logoutUserHandler() {
        userCtx.logout();
    }

    function profileScreenHandler() {
        navigation.navigate("Profile");
    }

    function themeScreenHandler() {
        Alert.alert('Not implemented yet')
    }

    function equipmentScreenHandler() {
        navigation.navigate("Equip");
    }

    function orgHandler() {
        navigation.navigate("OrganizationStack");
    }

    function switchModeHandler() {
        if(userCtx.userMode=='Athlete'){
            userCtx.switchUserMode('Coach');
        }
        else {
            userCtx.switchUserMode('Athlete');
        }
    }

    async function switchTeamHandler(teamData) {
        userCtx.switchTeam(teamData);
        const dbOrg = await fetchTeam(teamData.id, userCtx.token);
        const orgData = {
            id: dbOrg.data.organizationId,
            name: dbOrg.data.organizationName
        };
        userCtx.switchOrganization(orgData);
    }

    return (
        <ScrollView style={styles.backgroundView} contentContainerStyle={{ flexGrow: 1, justifyContent: 'center', alignItems: 'center' }}>
                <ShadowBox style={styles.containerView}>
                    <Text style={styles.textStyle}>User ID: </Text>
                    <Text style={styles.textStyle} selectable>{userId}</Text>
                    <Text style={styles.textStyle}></Text>
                    <Text style={styles.textStyle}>Screens Visible:{userMode}</Text>
                    <SelectDropdown 
                        data={teams}
                        onSelect={(selectedItem, index) => {
                            const teamData = {
                                id: selectedItem[0],
                                name: selectedItem[1],
                            };
                            switchTeamHandler(teamData);
                        }}
                        defaultButtonText={teams.length === 0 ? "No Teams" : userCtx.teamName}
                        // defaultValue={-1}
                        buttonTextAfterSelection={(selectedItem, index) => {
                            return selectedItem[1]
                        }}
                        rowTextForSelection={(item, index) => {
                            return item[1]
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
                        disabled={!teams.length}
                    />
                    <OurButton 
                        buttonPressed={() => profileScreenHandler()}
                        buttonText="Profile"
                        style={styles.buttonStyle}
                    />
                    <OurButton 
                        buttonPressed={() => themeScreenHandler()}
                        buttonText="Theme"
                        style={styles.buttonStyle}
                    />
                    <OurButton 
                        buttonPressed={() => equipmentScreenHandler()}
                        buttonText="Manage Equipment"
                        style={styles.thiccButtonStyle} />
                    <OurButton 
                        buttonPressed={() => orgHandler()}
                        buttonText="Your Orgs"
                        style={styles.buttonStyle} />
                    <OurButton 
                        buttonPressed={() => switchModeHandler()}
                        buttonText="Switch Mode"
                        style={styles.buttonStyle}
                    />
                    <OurButton 
                        buttonPressed={() => logoutUserHandler()}
                        buttonText="Logout"
                        style={styles.buttonStyle}
                    />
                </ShadowBox>
        </ScrollView>
    );
}

const styles = StyleSheet.create({
    backgroundView: {
        backgroundColor: '#ededed'
    },
    containerView: {
        flexWrap: 'nowrap',
        alignItems: 'center',
        borderWidth: 1,
        borderColor: 'gray',
        backgroundColor: '#ffffff',
        borderRadius: 10,
        marginVertical: 40,
        paddingVertical: 20,
        width: '80%'
    },
    thiccButtonStyle: {
        height: 75,
        fontSize: 25,
        margin: 20,
        width: '60%'
    },
    buttonStyle: {
        fontSize: 25,
        margin: 20,
        width: '60%'
    },
    textStyle: {
        fontSize: 16,
        textAlign: 'center',
        textAlignVertical: 'center',
        margin: 5
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
});

export default SettingsScreen;