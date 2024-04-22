import React, { useEffect } from 'react';
import { FlatList, Text, View, StyleSheet, TouchableOpacity } from 'react-native';
import ShadowBox from './ShadowBox';
import { Ionicons } from '@expo/vector-icons';

const Item = ({ name, distance}) => (
    // <ShadowBox>
    <View>
        <Text>{name}</Text>
        <Text>{distance}</Text>
    </View>
        // <TouchableOpacity>
        //     <Ionicons name="close-sharp" size={24} color="green" />
        // </TouchableOpacity>
    // </ShadowBox>
  );

const EquipmentList = (equipment) => {
    const renderEquipmentItem = ({ item }) => (
        <Item name={item.name} distance={item.distance} />
    );

    return (
        <View>
            <Text>Test</Text>
            <FlatList 
                data={equipment}
                renderItem={renderEquipmentItem}
                keyExtractor={(item) => item.id }
            />
        </View>
    );
}

const styles = StyleSheet.create({
    title: {
      fontSize: 32,
    },
  });

export default EquipmentList;