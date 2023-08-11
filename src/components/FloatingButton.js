import React from 'react';
import { View, Text, TouchableOpacity, StyleSheet } from 'react-native';
import { Ionicons } from '@expo/vector-icons';

const FloatingButton = props => {
  return (
    <View style={styles.container}>
      <TouchableOpacity style={{...styles.button, ...props.style}} onPress={() => props.pressHandler()}>
        <Ionicons name="add-circle-outline" size={24} color="white" />
      </TouchableOpacity>
    </View>
  );
};

export default FloatingButton;

const styles = StyleSheet.create({
    container: {
      position: 'absolute',
      bottom: 20,
      right: 20,
    },
    button: {
      backgroundColor: 'darkgreen',
      borderRadius: 50,
      width: 50,
      height: 50,
      justifyContent: 'center',
      alignItems: 'center',
    }
  });