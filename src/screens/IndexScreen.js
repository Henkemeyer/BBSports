import React, {useState, useRef} from 'react';
import { View, Text, StyleSheet } from 'react-native';
import {Picker} from '@react-native-picker/picker';
import UserContext from '../context/UserContext';
// import SearchBar from '../components/SearchBar';
// import ScrollList from '../components/ScrollList';

const IndexScreen = () => {
    // const value = useContext(UserContext);

    const [selectedLanguage, setSelectedLanguage] = useState();

    const testData = [
        { value: 'Tyler Henkemeyer', key: '1' },
        { value: 'Sydnee Henkemeyer', key: '2' },
        { value: 'Stephanie Henkemeyer', key: '3' },
        { value: 'Joey Henkemeyer', key: '4' },
        { value: 'James Henkemeyer', key: '5' },
        { value: 'Chuck Norris', key: '6' },
        { value: 'Trent Bartholf', key: '7' }
    ];

    const pickerRef = useRef();

    function open() {
        pickerRef.current.focus();
    }

    function close() {
        pickerRef.current.blur();
    }

    return (
        <View>
            {/* <Text>Index Screen</Text>
            <Text>User ID: {value}</Text>
            <SearchBar />
            <View style={styles.scrollViewStyle}>
                <Text>Athletes:</Text>
                <ScrollList 
                    style={styles.scrollListStyle}
                    ourData={testData} />
            </View> */}
                {/* <Text>Athletes:</Text> */}
                <Picker
                    style={styles.pickerStyle}
                    ref={pickerRef}
                    selectedValue={selectedLanguage}
                    onValueChange={(itemValue, itemIndex) =>
                        setSelectedLanguage(itemValue)
                    }>
                    <Picker.Item label="Java" value="java" />
                    <Picker.Item label="JavaScript" value="js" />
                </Picker>
        </View>
    );
};

const styles = StyleSheet.create({
    scrollViewStyle: {
        flexDirection: "row"
    },
    pickerStyle: {
        marginHorizontal: 20,
        marginTop: 20
    },
    scrollListStyle: {
        borderWidth: 1
    }
});

export default IndexScreen;