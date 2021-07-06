import React, { useState, useContext } from 'react';
import { View, Text, TextInput, TouchableOpacity, StyleSheet } from 'react-native';
// import { Context as AuthContext } from '../context/AuthContext';

const SignUpScreen = ({ navigation }) => {
    // const { state, signup } = useContext(AuthContext);
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [firstName, setFirstName] = useState('');
    const [lastName, setLastName] = useState('');

    return (
        <View style={styles.backgroundView}>
            <View style={styles.containerView}>
                <Text style={styles.headerText}>Sign Up for BB Sports</Text>
                    <View style={styles.inputView}>
                    <Text style={styles.inputText}>E-mail</Text>
                    <TextInput 
                        label="Email"
                        value={email}
                        onChangeText={setEmail}
                        autoCapitalize="none"
                        autoCorrect={false}
                        style={styles.inputComp}
                    />
                </View>

                <View style={styles.inputView}>
                    <Text style={styles.inputText}>Password:</Text>
                    <TextInput
                        secureTextEntry
                        label="Password"
                        value={password}
                        onChangeText={setPassword}
                        autoCapitalize="none"
                        autoCorrect={false}
                        style={styles.inputComp}
                    />
                </View>

                <View style={styles.inputView}>
                    <Text style={styles.inputText}>Re-Enter Password:</Text>
                    <TextInput
                        secureTextEntry
                        label="Password"
                        value={password}
                        onChangeText={setPassword}
                        autoCapitalize="none"
                        autoCorrect={false}
                        style={styles.inputComp}
                    />
                </View>
                {/* { state.errorMessage ? <Text style={styles.errorText}>{state.errorMessage}</Text> : null } */}

                <View style={styles.inputView}>
                    <Text style={styles.inputText}>First Name:</Text>
                    <TextInput
                        label="FirstName"
                        value={firstName}
                        onChangeText={setFirstName}
                        autoCorrect={false}
                        style={styles.inputComp}
                    />
                </View>

                <View style={styles.inputView}>
                    <Text style={styles.inputText}>Last Name:</Text>
                    <TextInput
                        label="LastName"
                        value={lastName}
                        onChangeText={setLastName}
                        autoCorrect={false}
                        style={styles.inputComp}
                    />
                </View>

                <TouchableOpacity  
                    onPress={() => navigation.Token='True'}
                    style={styles.loginButton}>
                    <Text style={styles.buttonText}>Create Account</Text>
                </TouchableOpacity>

                <TouchableOpacity onPress={() => navigation.navigate('Login')}>
                    <Text style={styles.clickText}>Already have an account?</Text>
                </TouchableOpacity>
            </View>
        </View>
    );
};

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
        marginVertical: 150
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
    inputText: {
        fontSize: 15,
        color: 'gray',
        marginBottom: 2
    },
    inputComp: {
        backgroundColor: 'white',
        borderWidth: 1,
        borderColor: 'black',
        borderRadius: 5,
        fontSize: 20
    },
    loginButton: {
        borderWidth: 1,
        borderRadius: 5,
        backgroundColor: '#268736',
        height: 40,
        maxWidth:300,
        marginBottom: 5,
        marginBottom: 15
    },
    buttonText: {
        fontSize:27,
        fontWeight: 'bold',
        alignSelf:'center',
        marginHorizontal: 5

    },
    clickText: {
        fontSize: 15,
        color: 'orange',
        marginBottom: 30
    }
});

export default SignUpScreen;