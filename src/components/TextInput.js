import React from 'react';
import { StyleSheet, Text, View, Input } from 'react-native';

const TextInput = () => {
    return (
        <View style={styles.viewStyle}>
            <Text> </Text>
            <Input style={styles.searchStyle} placeholder="Search" />
        </View>
    );
};

const styles = StyleSheet.create({
    
});
 
export default TextInput;