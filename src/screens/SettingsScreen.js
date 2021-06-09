import React from 'react';
import { StyleSheet, Text, View, TouchableHighlight} from 'react-native';

const SettingsScreen = () => {
    return (
        <View style={styles.buttonViewStyle}>
            <TouchableHighlight style={styles.buttonStyle} /*onPress={logout}*/ >
                <Text style={styles.textStyle}>Theme</Text>
            </TouchableHighlight>
            <TouchableHighlight style={styles.buttonStyle} /*onPress={logout}*/ >
                <Text style={styles.textStyle}>Logout</Text>
            </TouchableHighlight>
        </View>
    );
};

const styles = StyleSheet.create({
    buttonViewStyle: {
        alignItems: 'center',
        justifyContent: 'space-around',
        flex: 1
    },
    buttonStyle: {
        width: '33%',
        height: 35,
        borderWidth: 1,
        borderColor: 'black',
        borderRadius: 7,
        backgroundColor: 'green'
    },
    textStyle: {
        fontSize: 25,
        textAlign: 'center',
        textAlignVertical: 'center'
    }
});

export default SettingsScreen;