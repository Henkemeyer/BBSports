import React, { useContext, useEffect, useState } from 'react';
import { Alert, View, Text, TouchableOpacity, StyleSheet, Keyboard, TouchableWithoutFeedback } from 'react-native';
import SelectDropdown from 'react-native-select-dropdown';
import UserInput from '../components/UserInput';
import ShadowBox from '../components/ShadowBox';
import OurButton from '../components/OurButton';
import { UserContext } from '../store/context/user-context';
import { fetchOrganization } from '../util/http';
import { Ionicons } from '@expo/vector-icons';

function OrganizationScreen({ navigation }) {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [organizations, setOrganizations] = useState('');
    const [hasOrgs, setHasOrgs] = useState(false);

    const Item = ({ item }) => (
            <View style={styles.viewRow}>
                <View style={styles.equipmentDetails}>
                    <Text style={styles.text}>Name: {item.name}</Text>
                    <Text style={styles.text}>Position: {item.title}</Text>
                </View>
                <View style={styles.equipmentDetails}>
                    <Text style={styles.text}>Admin: {item.admin}</Text>
                    <TouchableOpacity onPress={() => retireHandler(item)}>
                        <Ionicons name="close-sharp" size={30} color="green" />
                 </TouchableOpacity>
                </View>
            </View>
      );

    useEffect(() => {
        async function getOrganizations() {
            const dbOrganizations = await fetchOrganization(userCtx.userId, token);
            setOrganizations(dbOrganizations);
            if(Object.keys(dbOrganizations).length > 0) { setHasOrgs(true); }
        }
    
        getOrganizations();
    }, [token]);

    function joinOrgHandler() {
        const placeholder = 1;
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

    const renderEquipmentItem = ({ item }) => (
        <Item item={item} />
    );

    return (
        <>
            {!hasOrgs ? (
                <TouchableWithoutFeedback onPress={() =>{ Keyboard.dismiss(); }}>
                    <View>
                        <Text>You're not a part of any Orgs. Create or Join one.</Text>
                        <OurButton 
                            buttonPressed={() => navigation.navigate('CreateOrg')}
                            buttonText="Create Org?"/>
                        <OurButton 
                            buttonPressed={() => joinOrgHandler()}
                            buttonText="Join Org?"/>
                    </View>
                </TouchableWithoutFeedback>
            ) : (
                <View style={styles.containerView}>
                    <Text style={styles.headerText}>Switch Organization?</Text>
                    <SelectDropdown 
                        data={organizations}
                        onSelect={(selectedItem, index) => {
                            const orgData = {
                                name: selectedItem.name,
                                id: selectedItem.id
                            }
                            userCtx.switchOrganization(orgData);
                            console.log(userCtx.organization);
                        }}
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
                    <Text style={styles.orgTitle}>{userCtx.organization ? userCtx.organization.name : 'No Org Selected'}</Text>
                    <Text style={styles.rosterHeader}>Coaches</Text>
                    {/* <FlatList 
                        data={coaches}
                        renderItem={renderCoachItem}
                        keyExtractor={(item) => item.id }
                    /> */}
                </View>
            )}
        </>
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
    headerText: {
        fontSize: 30,
        fontWeight: 'bold',
        margin: 15,
        color: 'darkgreen'
    },
    orgTitle: {
        borderTopWidth: 5,
        borderColor: 'darkgreen',
        width: '80%',
        fontSize: 30,
        fontWeight: 'bold',
        margin: 15,
        paddingTop: 10,
        color: 'darkgreen',
        textAlign: 'center'
    },
    rosterHeader: {
        borderTopWidth: 3,
        borderColor: 'darkgreen',
        width: '80%',
        fontSize: 20,
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
    }
});

export default OrganizationScreen;