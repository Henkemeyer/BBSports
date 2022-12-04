import React from 'react';
import { StyleSheet, Text, View, TextInput } from 'react-native';

const UserInput = props => {
    return (
        <View style={{...styles.container, ...props.style}}>
            <Text style={styles.inputHeader}>{props.label}</Text>
            <TextInput {...props} style={styles.input} />
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        width: '80%',
        backgroundColor: 'white',
        borderBottomWidth: 1,
        borderColor: 'darkgreen',
        margin:10,
        padding:5,
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