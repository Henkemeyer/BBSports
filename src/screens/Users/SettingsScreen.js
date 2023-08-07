import React, { useContext } from 'react';
import { Alert, ScrollView, StyleSheet, Text, View} from 'react-native';
import OurButton from '../../components/OurButton';
import ShadowBox from '../../components/ShadowBox';

import { UserContext } from '../../store/context/user-context';

function SettingsScreen ({navigation}) {
    const userCtx = useContext(UserContext);
    const userId = userCtx.userId;
    const userMode = userCtx.userMode;

    function logoutUserHandler() {
        userCtx.logout();
    }

    function profileScreenHandler() {
        navigation.navigate("Profile");
    }

    function themeScreenHandler() {
        Alert.alert('Not implemented yet')
    }

    function equipmentScreenHandler() {
        navigation.navigate("Equip");
    }

    function orgHandler() {
        navigation.navigate("OrganizationStack");
    }

    function switchModeHandler() {
        if(userCtx.userMode=='Athlete'){
            userCtx.switchUserMode('Coach');
        }
        else {
            userCtx.switchUserMode('Athlete');
        }
    }

    return (
        <ScrollView style={styles.backgroundView} contentContainerStyle={{ flexGrow: 1, justifyContent: 'center', alignItems: 'center' }}>
                <ShadowBox style={styles.containerView}>
                    <Text style={styles.textStyle}>User ID: </Text>
                    <Text style={styles.textStyle} selectable>{userId}</Text>
                    <Text style={styles.textStyle}></Text>
                    <Text style={styles.textStyle}>Screens Visible:{userMode}</Text>
                    <OurButton 
                        buttonPressed={() => profileScreenHandler()}
                        buttonText="Profile"
                        style={styles.buttonStyle}
                    />
                    <OurButton 
                        buttonPressed={() => themeScreenHandler()}
                        buttonText="Theme"
                        style={styles.buttonStyle}
                    />
                    <OurButton 
                        buttonPressed={() => equipmentScreenHandler()}
                        buttonText="Manage Equipment"
                        style={styles.thiccButtonStyle} />
                    <OurButton 
                        buttonPressed={() => orgHandler()}
                        buttonText="Your Orgs"
                        style={styles.buttonStyle} />
                    <OurButton 
                        buttonPressed={() => switchModeHandler()}
                        buttonText="Switch Mode"
                        style={styles.buttonStyle}
                    />
                    <OurButton 
                        buttonPressed={() => logoutUserHandler()}
                        buttonText="Logout"
                        style={styles.buttonStyle}
                    />
                </ShadowBox>
        </ScrollView>
    );
}

const styles = StyleSheet.create({
    backgroundView: {
        backgroundColor: '#ededed'
    },
    containerView: {
        flexWrap: 'nowrap',
        alignItems: 'center',
        borderWidth: 1,
        borderColor: 'gray',
        backgroundColor: '#ffffff',
        borderRadius: 10,
        marginVertical: 40,
        paddingVertical: 20,
        width: '80%'
    },
    thiccButtonStyle: {
        height: 75,
        fontSize: 25,
        margin: 20,
        width: '60%'
    },
    buttonStyle: {
        fontSize: 25,
        margin: 20,
        width: '60%'
    },
    textStyle: {
        fontSize: 16,
        textAlign: 'center',
        textAlignVertical: 'center',
        margin: 5
    }
});

export default SettingsScreen;