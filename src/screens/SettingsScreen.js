import React, { useContext } from 'react';
import { StyleSheet, Text, View, TouchableHighlight} from 'react-native';

import { UserContext } from '../store/context/user-context';

function SettingsScreen ({navigation}) {
    const userCtx = useContext(UserContext);
    const userId = userCtx.userId;

    function logoutUserHandler() {
        userCtx.logout();
    }

    return (
        <View style={styles.buttonViewStyle}>
            <Text>User ID:{userId}</Text>
            <TouchableHighlight style={styles.buttonStyle} /*onPress={}*/ >
                <Text style={styles.textStyle}>Theme</Text>
            </TouchableHighlight>
            <TouchableHighlight 
                style={styles.buttonStyle} 
                onPress={logoutUserHandler} >
                <Text style={styles.textStyle}>Logout</Text>
            </TouchableHighlight>
        </View>
    );
}

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