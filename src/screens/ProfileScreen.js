import React from 'react';
import { View, Text, StyleSheet } from 'react-native';
import OurButton from '../components/OurButton';

const ProfileScreen = () => {
    function placeholder() {

    }

    return (
        <View>
            <View>
                <Text>Profile Screen</Text>
            </View>
            <View>
                <Text>User ID:</Text>
                <Text>Profile Picture:</Text>
                <Text>Name:</Text>
                <Text>Alias:</Text>
                <Text>E-mail:</Text>
                <Text>State:</Text>
                <Text>Zip Code:</Text>
            </View>
            <OurButton 
                buttonPressed={() => placeholder()}
                buttonText="Edit/Save"
            />
        </View>
    );
};

const styles = StyleSheet.create({
    
});

export default ProfileScreen;