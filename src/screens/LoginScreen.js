import React, { useState, useContext } from 'react';
import { View, Text, Button, StyleSheet } from 'react-native';

const LoginScreen = () => {
    return (
        <View>
            <Text>Login</Text>
            <Text>Username:</Text>
            <Text>Password:</Text>
            <Button
                title="Login"
                onPress={() => navigation.navigate('TabStack')}
            />
        </View>
    );
};

const styles = StyleSheet.create({});

export default LoginScreen;