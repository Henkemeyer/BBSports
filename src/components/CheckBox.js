import React from 'react';
import { StyleSheet, TouchableOpacity, View } from 'react-native';
import Colors from '../constants/ColorThemes';
import { Ionicons } from '@expo/vector-icons';

export default function CheckBox({ checked, toggle }){
    if(!checked){
        return (
            <View style={styles.containerView}>
                <View style={{height:3}}/>
                <TouchableOpacity 
                    style={styles.unchecked}
                    onPress={() => toggle()}
                />
            </View>
        );
    }
    return (
        <View style={styles.containerView}>
            <TouchableOpacity onPress={() => toggle()} >
                <Ionicons name="ios-checkbox" size={24} color={Colors.primary} />
            </TouchableOpacity>
        </View>
    );
};

const styles = StyleSheet.create({
    containerView: {
        width:30,
        height:'100%',
        alignContent: 'center'
    },
    unchecked: {
        width: 21,
        height: 21,
        borderColor: 'gray',
        borderWidth: 2,
        borderRadius: 3
    }
});

// export default CheckBox;