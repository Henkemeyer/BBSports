import React from 'react';
import { View, StyleSheet } from 'react-native';

const ShadowBox = ( props ) => {
    return (
        <View style={{...styles.containerView, ...props.style}}>
            {props.children}
        </View>
    );
};

const styles = StyleSheet.create({
    containerView: {
        alignItems: 'center',
        borderWidth: 1,
        borderColor: 'gray',
        backgroundColor: '#ffffff',
        borderRadius: 10,
        shadowColor: 'black',
        shadowOpacity: 0.33,
        shadowRadius: 8,
        shadowOffset: { width: 0, height: 2 },
        elevation: 15
    }
});

export default ShadowBox;