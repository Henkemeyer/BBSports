import React, { useContext, useEffect, useState } from 'react';
import { FlatList, ScrollView, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import SelectDropdown from 'react-native-select-dropdown';
import OurButton from '../../components/OurButton';
import { UserContext } from '../../store/context/user-context';
import { fetchCoaches, fetchOrganizations, fetchOrgTeams } from '../../util/http';
import { Ionicons } from '@expo/vector-icons';

function OrganizationScreen({ navigation }) {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [organizations, setOrganizations] = useState('');
    const [orgIndex, setOrgIndex] = useState(-1);
    const [teamIndex, setTeamIndex] = useState(-1);
    const [teams, setTeams] = useState('');
    const [coaches, setCoaches] = useState('');
    const [noTeamsAlert, setNoTeamsAlert] = useState('');

    const Item = ({ item }) => (
        <View style={styles.viewRow}>
            <Text style={styles.rosterTextWide}>{item.fullName}</Text>
            <Text style={styles.rosterTextWide}>{item.title}</Text>
            <Text style={styles.rosterTextShort}>{item.status}</Text>
            <View>
                <TouchableOpacity onPress={() => retireHandler(item)}>
                    <Ionicons name="close-sharp" size={30} color="green" />
                </TouchableOpacity>
            </View>
        </View>
      );

    useEffect(() => {
        async function getOrganizations() {
            const dbOrganizations = await fetchOrganizations(userCtx.userId, token);
            setOrganizations(dbOrganizations);
            for (const key in organizations) {
                if(organizations[key].id === userCtx.organizationId) {
                    setOrgIndex(key);
                    break;
                }
            }
        }
    
        getOrganizations();
    }, [token]);

    useEffect(() => {
        async function getTeams() {
            const dbTeams = await fetchOrgTeams(userCtx.organizationId, token);
            setTeams(dbTeams);
            for (const key in teams) {
                if(teams[key].id === userCtx.teamId) {
                    setTeamIndex(key);
                    break;
                }
            }
        }
    
        getTeams();
    }, [userCtx.organizationId]);

    function selectTeamHandler(teamId) {
        // We should grab all and then filter so it doesn't pull from DB over and over if they keep flipping between them
        async function getCoaches() {
            const dbCoaches = await fetchCoaches(teamId, token);

            setCoaches(dbCoaches);
        }
    
        getCoaches();
    }

    function retireHandler(coach) {
        const placeholder = 1;
        // try {
        //     deleteEquipment(equip.id, token);
        //     console.log(equip.id);

        //     const tempEquip = equipment;
        //     const index = tempEquip.indexOf(equip);
        //     if (index !== -1) {
        //         tempEquip.splice(index, 1);
        //         setEquipment(() => [...tempEquip]);
        //     }
        // } catch (error) {
        //     console.log(error);
        //     Alert.alert('Retire Failed', 'Failed to remove coach. Please try again later.')
        // }
    }

    const renderCoachItem = ({ item }) => (
        <Item item={item} />
    );

    return (
        <View style={styles.containerView}>
            <Text style={styles.titleText}>Switch Organization?</Text>
            <SelectDropdown 
                data={organizations}
                onSelect={(selectedItem, index) => {
                    const orgData = {
                        name: selectedItem.name,
                        id: selectedItem.id
                    };
                    userCtx.switchOrganization(orgData);
                }}
                defaultButtonText="Organizations"
                defaultValue={userCtx.organizationId}
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
            <OurButton 
                buttonPressed={() => navigation.navigate('CreateOrg')}
                buttonText="Create?"
                style={styles.createButton}/>
            { userCtx.organizationId ? <>
                <Text style={styles.titleText}>Switch Team?</Text>
                <SelectDropdown
                    data={teams}
                    onSelect={(selectedItem, index) => {
                        const teamData = {
                            name: selectedItem.name,
                            id: selectedItem.id
                        };
                        userCtx.switchTeam(teamData);
                        selectTeamHandler(selectedItem.id);
                    }}
                    defaultButtonText="Teams"
                    defaultValueByIndex={teamIndex}
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
                { noTeamsAlert  ? <Text style={styles.errorText}>{noTeamsAlert}</Text>: null }
                <OurButton 
                    buttonPressed={() => navigation.navigate('CreateTeam')}
                    buttonText="Create?"
                    style={styles.createButton}/>
                </>    : null 
            }{ userCtx.teamId ? <>
                <Text style={styles.rosterTitle}>Coaches</Text>
                <View style={styles.rosterHeader}>
                    <Text style={styles.headerTextWide}>Name</Text>
                    <Text style={styles.headerTextWide}>Position</Text>
                    <Text style={styles.headerTextShort}>Status</Text>
                    <Text style={styles.headerTextShort}>Remove</Text>
                </View>
                <FlatList 
                    data={coaches}
                    renderItem={renderCoachItem}
                    keyExtractor={(item) => item.id }
                    style={styles.flatList}
                />
                <OurButton 
                    buttonPressed={() => navigation.navigate('AddCoach')}
                    buttonText="Hire?"
                    style={styles.createButton}/>
                </>    : null 
            }
            {/*
            <OurButton 
                    buttonPressed={() => joinOrgHandler()}
                    buttonText="Join Org?"/>
            */}
        </View>
    );
}

const styles = StyleSheet.create({
    backgroundView: {
        flex: 1,
        alignItems: 'center',
        justifyContent: 'center',
        borderWidth: 1,
        backgroundColor: '#ededed'
    },
    containerView: {
        flex: 1,
        alignItems: 'center',
        borderWidth: 1,
        borderColor: 'gray',
        backgroundColor: '#ffffff',
        borderRadius: 10,
        margin: 10,
    },
    createButton: {
       marginVertical: 20
    },
    titleText: {
        fontSize: 30,
        fontWeight: 'bold',
        margin: 15,
        color: 'darkgreen'
    },
    rosterTitle: {
        borderTopWidth: 3,
        borderColor: 'darkgreen',
        width: '80%',
        fontSize: 27,
        fontWeight: 'bold',
        margin: 5,
        paddingTop: 10,
        color: 'darkgreen',
        textAlign: 'center',
    },
    rosterHeader: {
        flexDirection: 'row',
        width: '100%',
        justifyContent: 'space-between',
        borderBottomColor: 'darkgreen',
        borderBottomWidth: 3,
        paddingHorizontal: 10
    },
    headerTextWide: {
        fontSize: 17,
        fontWeight: 'bold',
        paddingLeft: 5,
        color: 'darkgreen',
        width: '33%'
    },
    headerTextShort: {
        fontSize: 17,
        fontWeight: 'bold',
        color: 'darkgreen',
        width: '17%'
    },
    viewRow: {
        flexDirection: 'row',
        flex: 1,
        justifyContent: 'space-around',
        alignItems: 'center',
        marginTop: 5,
        padding: 5,
        borderColor: 'darkgreen',
        borderBottomWidth: 1,
    },
    rosterTextWide: {
        fontSize:16,
        flexWrap: 'wrap',
        width: '33%'
    },
    rosterTextShort: {
        fontSize:16,
        width: '17%',
        // paddingLeft: 10
    },
    inputView: {
        width: 250,
        marginBottom: 20
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
    errorText: {
        color: 'red',
        fontSize: 15,
        marginBottom: 15
    },
    flatList: {
        width: '100%'
    }
});

export default OrganizationScreen;