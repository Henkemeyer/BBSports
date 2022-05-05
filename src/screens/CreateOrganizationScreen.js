import React, { useContext, useState } from 'react';
import { Alert, View, Text, StyleSheet, Keyboard, KeyboardAvoidingView, TouchableWithoutFeedback } from 'react-native';
import UserInput from '../components/UserInput';
import ShadowBox from '../components/ShadowBox';
import OurButton from '../components/OurButton';
import { UserContext } from '../store/context/user-context';
import { postCoach, postOrganization } from '../util/http';

function CreateOrganizationScreen({ navigation }) {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [orgName, setOrgName] = useState('');
    const [level, setLevel] = useState('');
    const [location, setLocation] = useState('');
    const [description, setDescription] = useState('');
    const [nameError, setNameError] = useState('');
    const [isValid, setIsValid] = useState(false);

    const confirmInputAgent = () => {
        setIsValid(true);
        if(orgName.length < 2) {
            setNameError('*You must enter an Org Name');
            setIsValid(false);
        }
        if(isValid) {
            signUpHandler();
        }
    };

    async function signUpHandler() {
        try {
            const orgData = 
                {
                    name: orgName,
                    level: level,
                    location: location,
                    description: description,
                    coach: {
                        coachId: userCtx.userId,
                        admin: 'Y',
                        title: ''
                    }
                }

            const orgId = await postOrganization(orgData, token);
            navigation.goBack();
        } catch (error) {
            Alert.alert('Login Failed!', 'Failed to login. Please try again later.')
        }
    }

    return (
        <TouchableWithoutFeedback onPress={() =>{ Keyboard.dismiss(); }}>
            <View style={styles.backgroundView}>
                <ShadowBox style={styles.containerView}>
                    <Text style={styles.headerText}>Sign up a new Organization</Text>
                    <View style={styles.inputView}>
                        <UserInput
                            label="Name"
                            value={orgName}
                            onChangeText={setOrgName}
                            autoCorrect={false}
                        />
                    </View>
                    { nameError ? <Text style={styles.errorText}>{nameError}</Text> : null }

                    <View style={styles.inputView}>
                        <UserInput
                            label="Org Level"
                            value={level}
                            onChangeText={setLevel}
                            autoCorrect={false}
                        />
                    </View>
                    <View style={styles.inputView}>
                        <UserInput
                            label="Location"
                            value={location}
                            onChangeText={setLocation}
                            autoCorrect={false}
                        />
                    </View>

                    <View style={styles.inputView}>
                        <UserInput
                            label="Description"
                            value={description}
                            onChangeText={setDescription}
                            multiline
                            numberOfLines={6}
                        />
                    </View>

                    <OurButton
                        buttonPressed={confirmInputAgent}
                        buttonText="Create Org"
                        style={styles.confirmButton}
                    />
                </ShadowBox>
            </View>
        </TouchableWithoutFeedback>
    );
}

const styles = StyleSheet.create({
    backgroundView: {
        flex: 1,
        alignItems: 'center',
        borderWidth: 1,
        backgroundColor: '#ededed'
    },
    containerView: {
        flexWrap: 'nowrap',
        alignItems: 'center',
        borderWidth: 1,
        borderColor: 'gray',
        backgroundColor: '#ffffff',
        borderRadius: 10,
        marginVertical: 100,
        width: '80%'
    },
    headerText: {
        fontSize: 30,
        fontWeight: 'bold',
        margin: 15
    },
    inputView: {
        width: 250,
        marginBottom: 20
    },
    confirmButton: {
        marginBottom: 15,
        width: '75%'
    },
    clickText: {
        fontSize: 15,
        color: 'orange',
        marginBottom: 30
    },
    errorText: {
        color: 'red',
        fontSize: 15,
        marginBottom: 15
    }
});

export default CreateOrganizationScreen;