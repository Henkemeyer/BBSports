import React from 'react';
import { StyleSheet, Text, View, TextInput } from 'react-native';

const UserInput = props => {
    return (
        <View>
            <Text style={styles.inputHeader}>{props.label}</Text>
            <TextInput {...props} style={{...styles.input, ...props.style}} />
        </View>
    );
};

const styles = StyleSheet.create({
    inputHeader: {
        fontSize: 15,
        color: 'gray',
        marginBottom: 2
    },
    input: {
        backgroundColor: 'white',
        borderBottomWidth: 1,
        borderColor: 'black',
        fontSize: 20
    },
});
 
export default UserInput;