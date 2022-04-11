import React from 'react';
import { View, Text, StyleSheet } from 'react-native';

const ProfileScreen = () => {
    return (
        <View>
            <View>
                <Text>Profile Screen</Text>
            </View>
            <View>
                <Text>User ID:</Text>
                <Text>Profile Picture:</Text>
                <Text>Name:</Text>
                <Text>E-mail:</Text>
                <Text>ZipCode:</Text>
            </View>
            <Text>Edit/Save</Text>
        </View>
    );
};

const styles = StyleSheet.create({
    
});

export default ProfileScreen;