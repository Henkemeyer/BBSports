import React from 'react';
import { View, Text, StyleSheet } from 'react-native';

const LiftingScreen = () => {

    return (
        <View style={styles.container}>
            <Text>Title: (Legs?)</Text>
            <Text>Date: Today</Text>
            <Text>Custom list Comp:</Text>
            <View style={styles.placeHolder}>
                <Text>Lift One</Text>
                <Text>Record Lift 1</Text>
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
    placeHolder: {
        flexDirection: 'row',
        justifyContent: 'space-around'
    }
});

export default LiftingScreen;