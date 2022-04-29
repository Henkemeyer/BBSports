import React, { useContext, useEffect, useState } from 'react';
import { Alert, FlatList, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import OurButton from '../components/OurButton';
import UserInput from '../components/UserInput';
import ShadowBox from '../components/ShadowBox';
import EquipmentList from '../components/EquipmentList';
import { fetchEquipment } from '../util/http';
import { postEquipment } from '../util/http';
import { UserContext } from '../store/context/user-context';
import { Ionicons } from '@expo/vector-icons';

const Item = ({ name, distance}) => (
    // <ShadowBox>
        <View style={styles.viewRow}>
            <View style={styles.equipmentDetails}>
                <Text style={styles.text}>Name: {name}</Text>
                <Text style={styles.text}>Use: {distance}</Text>
            </View>
            <TouchableOpacity>
                <Ionicons name="close-sharp" size={30} color="green" />
            </TouchableOpacity>
        </View>
    // </ShadowBox>
  );

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

    const renderEquipmentItem = ({ item }) => (
        <Item name={item.name} distance={item.distance} />
    );

    function submitHandler() {
        try {
            const equipData = 
                {
                    uid: userCtx.userId,
                    equipName: newEquipName,
                    distance: 0,
                    description: '',
                }

            postEquipment(equipData, token);
            const newEquip = [{id:newEquipName, name:newEquipName, distance:0}];
            setEquipment((prevState) => [...prevState, ...newEquip]);
            setNewEquipName("");
        } catch (error) {
            console.log(error);
            Alert.alert('Addition Failed', 'Failed to add equipment. Please try again later.')
        }
    }

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
