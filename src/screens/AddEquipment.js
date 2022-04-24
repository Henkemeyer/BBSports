import React from 'react';
import { View, Text, StyleSheet } from 'react-native';

const AddEquipmentScreen = () => {

    return (
        <View style={styles.container}>
            <Text>Add Equipment</Text>
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        margin: 30
    },
});

export default AddEquipmentScreen;