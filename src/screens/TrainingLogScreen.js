import React, { useState } from 'react';
import { View, Text, TextArea, StyleSheet, Keyboard, TouchableWithoutFeedback } from 'react-native';

import UserInput from '../components/UserInput';
import OurButton from '../components/OurButton';
import Colors from '../constants/ColorThemes';

const TrainingLogScreen = ( ) => {
    const [getLength, setLength] = useState('');
    const [getNotes, setNotes] = useState('');

    return (
        <View style={styles.container}>
            <TouchableWithoutFeedback 
            onPress={() =>{
                Keyboard.dismiss();
            }}
            >
                <View>
                    <Text style={styles.headerText}>Training Log</Text>
                    <Text style={styles.headerText}>Date</Text>
                    <View style={styles.lengthRow}>
                        <UserInput
                            label="Length:"
                            onChangeText={setLength}
                            keyboardType='numeric'
                            autoCorrect={false}
                            maxLength={7}
                            style={{width: 275}}
                        />
                        <Text>Units</Text>
                    </View>
                    <Text>Shoes</Text>
                    <Text>Add Shoe Selector</Text>
                    <UserInput
                        label="Notes:"
                        onChangeText={setNotes}
                        multiline
                        numberOfLines={6}
                        style={styles.notesInput}
                    />
                    <OurButton 
                        buttonPressed={() => submitLog()}
                        buttonText="Submit"
                    />
                </View>
            </TouchableWithoutFeedback>
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        paddingVertical: 30,
        paddingHorizontal: 10
    },
    headerText: {
        paddingTop: 25,
        fontSize: 30,
        textAlign: 'center',
        textAlignVertical: 'center'
    },
    lengthRow: {
        flexDirection: 'row',
        padding: 10,
        width: '100%',
        justifyContent: 'space-evenly'
    },
    notesInput: {
        height: 150,
        borderRadius: 8,
        elevation: 4,
        shadowColor: 'black',
        shadowOpacity: 0.25,
        shadowOffset: {width: 0, height: 2 },
        shadowRadius: 8
    }
});

export default TrainingLogScreen;