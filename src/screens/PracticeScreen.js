import React, { useContext } from 'react';
import { View, Text, StyleSheet } from 'react-native';
import { UserContext } from '../store/context/user-context';

const PracticeScreen = () => {
    const userCtx = useContext(UserContext);
    const userId = userCtx.userId;

    return (
        <View style={styles.container}>
            <Text>User ID:{userId}</Text>
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        padding: 30
    },
});

export default PracticeScreen;