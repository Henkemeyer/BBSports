import React, { useEffect } from 'react';
import { View, Text, StyleSheet } from 'react-native';
import EquipmentList from '../components/EquipmentList';
import { fetchEquipment } from '../util/http';

const EquipmentScreen = () => {

    useEffect(() => {
        async function getEquipment() {
            const equipment = await fetchEquipment();
        }
    
        getEquipment();
    }, []);

    return (
        <View style={styles.container}>
            <Text style={styles.title}>Your Equipment</Text>
            <EquipmentList equipment={equipment}/>
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        paddingHorizontal: 25,
        paddingTop: 12,
        borderRadius: 7,
        justifyContent: 'space-between',
        alignItems: 'center'
    },
    title: {
        fontSize: 20,
        fontWeight: 'bold'
    }
});

export default EquipmentScreen;