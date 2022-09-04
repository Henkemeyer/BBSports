import React from 'react';
import { StyleSheet, TouchableOpacity, View } from 'react-native';
import Colors from '../constants/ColorThemes';
import { MaterialIcons } from '@expo/vector-icons';

export default function CheckBox({ checked, toggle }){
    if(!checked){
        return (
            <View style={styles.containerView}>
                <TouchableOpacity onPress={() => toggle()} >
                    <MaterialIcons name="check-box-outline-blank" size={24} color={Colors.primary} />
                </TouchableOpacity>
            </View>
        );
    } else {
        return (
            <View style={styles.containerView}>
                <TouchableOpacity onPress={() => toggle()} >
                    <MaterialIcons name="check-box" size={24} color={Colors.primary} />
                </TouchableOpacity>
            </View>
        );
    }
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