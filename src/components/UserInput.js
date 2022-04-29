import React from 'react';
import { StyleSheet, Text, View, TextInput } from 'react-native';

const UserInput = props => {
    return (
        <View style={styles.container}>
            <Text style={styles.inputHeader}>{props.label}</Text>
            <TextInput {...props} style={{...styles.input, ...props.style}} />
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        backgroundColor: 'white',
        borderBottomWidth: 1,
        borderColor: 'black',
        margin:10,
        padding:5,
        height:60,
        borderRadius:8
    },
    inputHeader: {
        fontSize: 15,
        color: 'gray',
        marginBottom: 2
    },
    input: {
        fontSize: 20
    },
});
 
export default UserInput;