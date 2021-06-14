import React, { useState, useContext } from 'react';
import { View, Text, Input, Button, StyleSheet } from 'react-native';
import { AuthContext } from '../context/AuthContext';

const SignUpScreen = ({ navigation }) => {
    const { state, signup } = useContext(AuthContext);
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');

    return (
        <View style={styles.container}>
            <Text>Sign Up for BB Sports</Text>
            <View>
                <Text>Username:</Text>
                <Input 
                    label="Email"
                    value={email}
                    onChangeText={setEmail}
                    autoCapitalize="none"
                    autoCorrect={false}
                />
            </View>
            <View>
                <Text>Password:</Text>
                <Input
                    secureTextEntry
                    label="Password"
                    value={password}
                    onChangeText={setPassword}
                    autoCapitalize="none"
                    autoCorrect={false}
                />
            </View>
            { state.errorMessage ? <Text style={styles.errorText}>{state.errorMessage}</Text> : null }
            <Button
                title="Sign Up"
                onPress={() => signup({ email, password })}
            />
            <Button
                title="Sign Into BB Sports"
                onPress={() => navigation.navigate('Login')}
            />
        </View>
    );
};

SignUpScreen.navigationOptions = () => {
    return {
      headerShown: false,
    };
  };

const styles = StyleSheet.create({
    container: {
        justifyContent: 'center'
    },
    errorText: {
        margin: 15,
        color: 'red',
        fontSize: 18
    }
});

export default SignUpScreen;