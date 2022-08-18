import React, { useContext, useEffect, useState } from 'react';
import { FlatList, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import SelectDropdown from 'react-native-select-dropdown';
import OurButton from '../components/OurButton';
import { UserContext } from '../store/context/user-context';
import { fetchOrganizations, fetchTeams } from '../util/http';
import { Ionicons } from '@expo/vector-icons';

function OrganizationScreen({ navigation }) {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [organizations, setOrganizations] = useState('');
    const [teams, setTeams] = useState('');
    const [coaches, setCoaches] = useState('');

    const Item = ({ item }) => (
        <View style={styles.viewRow}>
            <View style={styles.coachDetails}>
                <Text style={styles.clickText}>Name: {item.name}</Text>
                <Text style={styles.clickText}>Position: {item.title}</Text>
            </View>
            <View style={styles.coachDetails}>
                <Text style={styles.clickText}>Admin: {item.admin}</Text>
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
        }
    
        getOrganizations();
    }, [token]);

    function selectOrgHandler(orgId) {
        // We should grab all and then filter so it doesn't pull from DB over and over if they keep flipping between them
        async function getTeams() {
            const dbTeams = await fetchTeams(orgId, token);
            setTeams(dbTeams);
        }
    
        getTeams();
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
            <Text style={styles.headerText}>Switch Organization?</Text>
            <SelectDropdown 
                data={organizations}
                onSelect={(selectedItem, index) => {
                    const orgData = {
                        name: selectedItem.name,
                        id: selectedItem.id
                    };
                    userCtx.switchOrganization(orgData);
                    selectOrgHandler(selectedItem.id);
                }}
                defaultButtonText="Organizations"
                defaultValue={userCtx.organization.id}
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
            { userCtx.organization.id ? <>
                <Text style={styles.headerText}>Switch Team?</Text>
                <SelectDropdown
                    data={teams}
                    onSelect={(selectedItem, index) => {
                        const teamData = {
                            name: selectedItem.name,
                            id: selectedItem.id
                        }
                        // userCtx.switchOrganization(orgData);
                        // console.log(userCtx.organization);
                    }}
                    defaultButtonText="Teams"
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
                    buttonPressed={() => navigation.navigate('CreateTeam')}
                    buttonText="Create?"
                    style={styles.createButton}/>
                <Text style={styles.rosterHeader}>Coaches</Text>
                <FlatList 
                    data={coaches}
                    renderItem={renderCoachItem}
                    keyExtractor={(item) => item.id }
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
    headerText: {
        fontSize: 30,
        fontWeight: 'bold',
        margin: 15,
        color: 'darkgreen'
    },
    rosterHeader: {
        borderTopWidth: 3,
        borderColor: 'darkgreen',
        width: '80%',
        fontSize: 27,
        fontWeight: 'bold',
        margin: 5,
        paddingTop: 10,
        color: 'darkgreen',
        textAlign: 'center'
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
    clickText: {
        fontSize: 15,
        color: 'orange',
        marginBottom: 30
    },
    errorText: {
        color: 'red',
        fontSize: 15,
        marginBottom: 15
    },
    viewRow: {
        flexDirection: 'row',
        justifyContent: 'space-between',
        alignItems: 'center',
        marginTop: 8,
        padding: 5,
        borderColor: 'darkgreen',
        borderWidth: 1,
        borderRadius: 6
    },
    coachDetails: {
        maxWidth: '80%'
    }
});

export default OrganizationScreen;