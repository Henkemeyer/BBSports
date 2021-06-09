import React from 'react';
import { View, FlatList, StyleSheet, Text } from 'react-native';

const ScrollList = props => {
    return (
        <View style={styles.viewStyle}>
            <FlatList 
                data={props.ourData}
                renderItem={({ item }) => {
                    return <Text>{ item.value }</Text>
                }}
            />
        </View>
    );
};

const styles = StyleSheet.create({
    viewStyle: {
        marginHorizontal:10,
        marginTop: 10
    }
});

export default ScrollList;