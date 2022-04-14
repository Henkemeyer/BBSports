import React from 'react';
import { View, Text, StyleSheet } from 'react-native';
import OurCalander from '../components/OurCalander';

const AthleteCalendarScreen = () => {

    return (
        <View style={styles.container}>
            <OurCalander />
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        margin: 30
    },
});

export default AthleteCalendarScreen;