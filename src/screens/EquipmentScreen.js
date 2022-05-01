import React, { useContext, useEffect, useState } from 'react';
import { Alert, FlatList, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import OurButton from '../components/OurButton';
import UserInput from '../components/UserInput';
import ShadowBox from '../components/ShadowBox';
import EquipmentList from '../components/EquipmentList';
import { postEquipment, fetchEquipment, deleteEquipment } from '../util/http';
import { UserContext } from '../store/context/user-context';
import { Ionicons } from '@expo/vector-icons';

const EquipmentScreen = () => {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [newEquipName, setNewEquipName] = useState('');
    const [equipment, setEquipment] = useState([]);

    useEffect(() => {
        async function getEquipment() {
            const dbEquipment = await fetchEquipment(userCtx.userId, token);
            setEquipment(dbEquipment);
        }
    
        getEquipment();
    }, [token]);

    const Item = ({ item }) => (
        // <ShadowBox>
            <View style={styles.viewRow}>
                <View style={styles.equipmentDetails}>
                    <Text style={styles.text}>Name: {item.name}</Text>
                    <Text style={styles.text}>Use: {item.distance}</Text>
                </View>
                <TouchableOpacity onPress={() => retireHandler(item)}>
                    <Ionicons name="close-sharp" size={30} color="green" />
                </TouchableOpacity>
            </View>
        // </ShadowBox>
      );
    
    function retireHandler(equip) {
        try {
            deleteEquipment(equip.id, token);
            console.log(equip.id);

            const tempEquip = equipment;
            const index = tempEquip.indexOf(equip);
            if (index !== -1) {
                tempEquip.splice(index, 1);
                setEquipment(() => [...tempEquip]);
            }
        } catch (error) {
            console.log(error);
            Alert.alert('Retire Failed', 'Failed to retire equipment. Please try again later.')
        }
    }

    async function submitHandler() {
        try {
            const equipData = 
                {
                    uid: userCtx.userId,
                    equipName: newEquipName,
                    distance: 0,
                    description: '',
                }

            const id = await postEquipment(equipData, token);
            const newEquip = [{id:id, name:newEquipName, distance:0}];
            setEquipment((prevState) => [...prevState, ...newEquip]);
            setNewEquipName("");
        } catch (error) {
            console.log(error);
            Alert.alert('Addition Failed', 'Failed to add equipment. Please try again later.')
        }
    }
    
    const renderEquipmentItem = ({ item }) => (
        <Item item={item} />
    );

    return (
        <View style={styles.container}>
            <FlatList 
                data={equipment}
                renderItem={renderEquipmentItem}
                keyExtractor={(item) => item.id }
            />
            <View style={styles.viewRow}>
                <UserInput
                    label="Equipment Name"
                    value={newEquipName}
                    onChangeText={setNewEquipName}
                />
                <OurButton
                    buttonPressed={() => submitHandler()}
                    buttonText="Add"
                />
            </View>
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        padding: 18,
    },
    title: {
        fontSize: 20,
        fontWeight: 'bold'
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
    text: {
        fontSize: 22,
        color: 'green'
    },
    equipmentDetails: {
        maxWidth: '80%'
    }
});

export default EquipmentScreen;
