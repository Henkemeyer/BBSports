import React, { useContext } from 'react';
import { StyleSheet, Text, View, TouchableHighlight} from 'react-native';
import OurButton from '../components/OurButton';

import { UserContext } from '../store/context/user-context';

function SettingsScreen ({navigation}) {
    const userCtx = useContext(UserContext);
    const userId = userCtx.userId;
    const userType = userCtx.userType;

    function logoutUserHandler() {
        userCtx.logout();
    }

    function switchTypeHandler() {
        if(userCtx.userType=='Athlete'){
            userCtx.switchUserType('Coach');
        }
        else {
            userCtx.switchUserType('Athlete');
        }
    }

    return (
        <View style={styles.buttonViewStyle}>
            <Text>User ID:{userId}</Text>
            <Text>Screens Visible:{userType}</Text>
            <OurButton 
                buttonPressed={() => placeholder()}
                buttonText="Theme"
            />
            <OurButton 
                buttonPressed={() => switchTypeHandler()}
                buttonText="Swap User"
            />
            <OurButton 
                buttonPressed={() => logoutUserHandler()}
                buttonText="Logout"
            />
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