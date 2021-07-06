import React from 'react';
import { View, StyleSheet, Text, TouchableOpacity } from 'react-native';
import Colors from '../constants/ColorThemes';

const OurButton = ( props ) => {
    <TouchableOpacity 
        style={styles.button}
        onPress={}
        >
        <Text style={styles.buttonText}></Text>
    </TouchableOpacity>
};

const style = StyleSheet.create({
    button: {
        borderWidth: 1,
        borderRadius: 5,
        backgroundColor: Colors.primary,
        height: 40,
        width: '40%',
        maxWidth: 300,
        shadowColor: 'black',
        shadowOffset: { width: 0, height: 2 },
        shadowRadius: 6,
        shadowOpacity: 0.33,
        elevation: 10
    },
    buttonText: {
        fontSize:27,
        fontWeight: 'bold',
        alignSelf:'center',
        marginHorizontal: 5,
        marginBottom: 25
    }
});

export default OurButton;