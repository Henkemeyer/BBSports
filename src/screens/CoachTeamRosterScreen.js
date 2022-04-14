import React from 'react';
import { View, Text, StyleSheet } from 'react-native';

const CoachTeamRosterScreen = () => {

    return (
        <View style={styles.container}>
            <Text style={styles.title}>Coach's Roster</Text>
            <View style={styles.header}>
                <Text>Organization</Text>
                <Text>Team</Text>
                <Text>Name</Text>
                <Text>Group</Text>
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
        fontSize: 30,
        textAlign: 'center',
        textAlignVertical: 'center'
    },
    header: {
        flexDirection: 'row',
        justifyContent: 'space-around'
    },
    rosterRow: {
        flexDirection: 'row',
    }
});

export default CoachTeamRosterScreen;