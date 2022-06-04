import React, { useContext } from 'react';
import { ScrollView, StyleSheet, Text, View, TouchableHighlight} from 'react-native';
import OurButton from '../components/OurButton';

import { UserContext } from '../store/context/user-context';

function SettingsScreen ({navigation}) {
    const userCtx = useContext(UserContext);
    const userId = userCtx.userId;
    const userType = userCtx.userType;

    function logoutUserHandler() {
        userCtx.logout();
    }

    function equipmentScreenHandler() {
        navigation.navigate("EquipmentStack");
    }

    function orgHandler() {
        navigation.navigate("OrganizationStack");
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
        <ScrollView>
            <View style={styles.buttonViewStyle}>
                <Text style={styles.textStyle}>User ID:{userId}</Text>
                <Text style={styles.textStyle}>Screens Visible:{userType}</Text>
                <Text style={styles.textStyle}>Fair Weather Mode: OFF</Text>
                <OurButton 
                    buttonPressed={() => placeholder()}
                    buttonText="Theme"
                    style={styles.buttonStyle}
                />
                {userCtx.userType=='Athlete' ? (
                    <OurButton 
                        buttonPressed={() => equipmentScreenHandler()}
                        buttonText="Manage Equipment"
                        style={styles.thiccButtonStyle} />
                ) : (
                    <OurButton 
                        buttonPressed={() => orgHandler()}
                        buttonText="Your Orgs"
                        style={styles.buttonStyle} />
                )}
                <OurButton 
                    buttonPressed={() => switchTypeHandler()}
                    buttonText="Swap User"
                    style={styles.buttonStyle}
                />
                <OurButton 
                    buttonPressed={() => logoutUserHandler()}
                    buttonText="Logout"
                    style={styles.buttonStyle}
                />
            </View>
        </ScrollView>
    );
}

const styles = StyleSheet.create({
    buttonViewStyle: {
        alignItems: 'center',
        flex: 1
    },
    thiccButtonStyle: {
        height: 75,
        fontSize: 25,
        margin: 20
    },
    buttonStyle: {
        fontSize: 25,
        margin: 20
    },
    textStyle: {
        fontSize: 16,
        textAlign: 'center',
        textAlignVertical: 'center',
        margin: 20
    }
});

export default SettingsScreen;