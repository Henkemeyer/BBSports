import React from 'react';
import { View, TextInput, StyleSheet } from 'react-native';
import { Ionicons } from '@expo/vector-icons';

const SearchBar = () => {
    return (
        <View style={styles.viewStyle}>
            <Ionicons name="search-sharp" style={styles.iconStyle} />
            <TextInput style={styles.searchStyle} placeholder="Search" />
        </View>
    );
};

const styles = StyleSheet.create({
    viewStyle: {
        backgroundColor:'#F0EEEE',
        borderRadius:3,
        height:40,
        marginHorizontal:15,
        marginTop: 10,
        flexDirection: 'row'
    },
    iconStyle: {
        fontSize: 30,
        alignSelf: 'center',
        color: 'black',
        marginHorizontal: 12
    },
    searchStyle: {
        fontSize: 18,
        flex: 1
    }
});

export default SearchBar;