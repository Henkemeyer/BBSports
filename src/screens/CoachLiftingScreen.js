import React from 'react';
import { View, Text, StyleSheet } from 'react-native';

const CoachLiftingScreen = () => {

    return (
        <View style={styles.container}>
            <Text style={styles.title}>Coaches Screen</Text>
            <Text>Date: Today</Text>
            <Text>Custom list Comp:</Text>
            <View style={styles.header}>
                <Text>Set</Text>
                <Text>Lift</Text>
                <Text>Amount</Text>
                <Text>Unit</Text>
                <Text>Reps</Text>
            </View>
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        margin: 20,
        paddingTop: 10
    },
    title: {
        fontSize: 25,
        textAlign: 'center',
        textAlignVertical: 'center'
    },
    header: {
        flexDirection: 'row',
        justifyContent: 'space-around'
    }
});

export default CoachLiftingScreen;