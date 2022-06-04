import React, { useContext, useState } from 'react';
import { Alert, Keyboard, ScrollView, StyleSheet, Text, TouchableOpacity, TouchableWithoutFeedback, View } from 'react-native';
import UserInput from '../components/UserInput';
import ShadowBox from '../components/ShadowBox';
import OurButton from '../components/OurButton';
import { UserContext } from '../store/context/user-context';
import { authenticate } from '../util/auth';
import { postUser } from '../util/http';

function SignUpScreen({ navigation }) {
    const userCtx = useContext(UserContext);
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [firstName, setFirstName] = useState('');
    const [nickName, setNickName] = useState('');
    const [lastName, setLastName] = useState('');
    const [emailError, setEmailError] = useState('');
    const [passwordError, setPWError] = useState('');
    const [firstError, setFirstError] = useState('');
    const [lastError, setLastError] = useState('');
    const [isValid, setIsValid] = useState(false);

    const confirmInputAgent = () => {
        setIsValid(true);
        if(email.length < 4) {
            setEmailError('*You must enter a valid Email');
            setIsValid(false);
        }
        if(password.length < 6) {
            setPWError('*You must enter a valid password');
            setIsValid(false);
        }
        if(firstName.length < 0) {
            setFirstError('*You must enter a valid first name');
            setIsValid(false);
        }
        if(lastName.length < 0) {
            setLastError('*You must enter a valid last name');
            setIsValid(false);
        }
        if(isValid) {
            signUpHandler();
        }
    };

    async function signUpHandler() {
        try {
            const authData = await authenticate('signUp', email, password);
            const userData = 
                {
                    uid: authData.localId,
                    firstName: firstName,
                    nickName: nickName,
                    lastName: lastName,
                    nickname: '',
                }

            postUser(userData, authData.idToken)
            userCtx.login(authData);
        } catch (error) {
            Alert.alert('Login Failed!', 'Failed to login. Please check E-mail and Password.')
        }
    }

    return (
        <TouchableWithoutFeedback
            onPress={() =>{
                Keyboard.dismiss();
            }}
        >
            <ScrollView>
                <View style={styles.backgroundView}>
                    <ShadowBox style={styles.containerView}>
                        <Text style={styles.headerText}>Sign Up for BB Sports</Text>
                            <View style={styles.inputView}>
                                <UserInput
                                    label="Email"
                                    value={email.trim()}
                                    onChangeText={setEmail}
                                    autoCapitalize="none"
                                    autoCorrect={false}
                                />
                        </View>
                        { emailError ? <Text style={styles.errorText}>{emailError}</Text> : null }

                        <View style={styles.inputView}>
                            <UserInput
                                secureTextEntry
                                label="Password"
                                value={password}
                                onChangeText={setPassword}
                                autoCapitalize="none"
                                autoCorrect={false}
                            />
                        </View>
                        { passwordError ? <Text style={styles.errorText}>{passwordError}</Text> : null }

                        <View style={styles.inputView}>
                            <UserInput
                                label="First Name"
                                value={firstName}
                                onChangeText={setFirstName}
                                autoCorrect={false}
                            />
                        </View>
                        { firstError ? <Text style={styles.errorText}>{firstError}</Text> : null }

                        <View style={styles.inputView}>
                            <UserInput
                                label="Nickname"
                                value={nickName}
                                onChangeText={setNickName}
                                autoCorrect={false}
                            />
                        </View>

                        <View style={styles.inputView}>
                            <UserInput
                                label="Last Name"
                                value={lastName}
                                onChangeText={setLastName}
                                autoCorrect={false}
                            />
                        </View>
                        { lastError ? <Text style={styles.errorText}>{lastError}</Text> : null }

                        <OurButton
                            buttonPressed={confirmInputAgent}
                            buttonText="Create Account"
                            style={styles.loginButton}
                        />
                        <TouchableOpacity onPress={() => navigation.navigate('Login')}>
                            <Text style={styles.clickText}>Already have an account?</Text>
                        </TouchableOpacity>
                    </ShadowBox>
                </View>
            </ScrollView>
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
        marginVertical: 40,
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
    loginButton: {
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

export default SignUpScreen;