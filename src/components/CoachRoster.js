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

const CoachRoster = (coaches) => {
    const renderCoachItem = ({ item }) => (
        <Item name={item.name} position={item.position} />
    );

    return (
        <View>
            <Text>Test</Text>
            <FlatList 
                data={coaches}
                renderItem={renderCoachItem}
                keyExtractor={(item) => item.id }
            />
        </View>
    );
}

const styles = StyleSheet.create({
    title: {
      fontSize: 32,
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
    }
  });

export default CoachRoster;