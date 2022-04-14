import React, { useState } from 'react';
import { ScrollView, View, Text, TouchableOpacity, StyleSheet, Keyboard, TouchableWithoutFeedback } from 'react-native';
import UserInput from '../components/UserInput';
import ShadowBox from '../components/ShadowBox';
import OurButton from '../components/OurButton';

function SignUpScreen({ navigation }) {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [firstName, setFirstName] = useState('');
    const [lastName, setLastName] = useState('');
    const [emailError, setEmailError] = useState('');
    const [passwordError, setPWError] = useState('');
    const [firstError, setFirstError] = useState('');
    const [lastError, setLastError] = useState('');

    const confirmInputAgent = () => {
        if(email.length < 4) {
            setEmailError('*You must enter a valid Email');
        }
        if(password.length < 6) {
            setPWError('*You must enter a valid password');
        }
        if(firstName.length < 1) {
            setFirstError('*You must enter a valid first name');
        }
        if(lastName.length < 1) {
            setLastError('*You must enter a valid last name');
        }
    };

    return (
        <TouchableWithoutFeedback
            onPress={() =>{
                Keyboard.dismiss();
            }}
        >
            <View style={styles.backgroundView}>
                <ShadowBox style={styles.containerView}>
                    <Text style={styles.headerText}>Sign Up for BB Sports</Text>
                        <View style={styles.inputView}>
                            <UserInput
                                label="Email"
                                value={email}
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