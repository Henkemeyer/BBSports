import React, {useContext} from 'react';
import { View, Text, StyleSheet } from 'react-native';
import UserContext from '../context/UserContext';
import SearchBar from '../components/SearchBar';

const IndexScreen = () => {
    const value = useContext(UserContext);

    return (
        <View>
            <Text>Index Screen</Text>
            <Text>User ID: {value}</Text>
            <SearchBar />
        </View>
    );
};

const styles = StyleSheet.create({});

export default IndexScreen;