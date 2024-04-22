import React, { useContext, useEffect, useState } from 'react';
import { Alert, FlatList, ScrollView, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import SelectDropdown from 'react-native-select-dropdown';
import OurButton from '../../components/OurButton';
import { UserContext } from '../../store/context/user-context';
import UserInput from '../../components/UserInput';
import { fetchMessages, postMessage } from '../../util/http';
import { format } from 'date-fns';
import { Ionicons } from '@expo/vector-icons';

function MessagingScreen({ route, navigation }) {
    const chatRoom = route.params;
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [inputText, setInputText] = useState("");
    const [renderedMessages, setRenderedMessages] = useState([]);

    useEffect(() => {
        async function getMessages() {
            let dbMessages = {};
            try {
                const response = await fetchMessages(chatRoom.id, token);
                dbMessages = response.data;
            } catch (error) {
                Alert.alert('Messaging Failed!', 'Failed to fetch chat room. '+error)
            }
            const messages = Object.entries(dbMessages).map((item, index) => (
                <View key={'v'+index} style={styles.messageView}>
                    <Text key={index}>{item[1].from} {item[1].time}{'\n'}{item[1].text}</Text>
                </View>
              ));
            setRenderedMessages(messages);
        }
        getMessages();
    }, []);

    async function sendTextHandler() {
        const newMessage = {
            "from": userCtx.name, 
            "text": inputText,
            "time": new Date()
        };
        await postMessage(chatRoom.id, newMessage)
        .then(function (response) {
            let newList = renderedMessages;
            newList[response.data.name] = newMessage;
            setRenderedMessages(newList);
            setInputText('');
        })
        .catch(function (error) {
            console.log(error);
        });
    }

    return (
        <View style={styles.backgroundView}>
            <Text style={styles.headerText}>{chatRoom.roomName}</Text>
            {renderedMessages}
            <View style={styles.rowView}>
                <UserInput
                    // label="Email"
                    value={inputText}
                    onChangeText={setInputText}
                />
                <TouchableOpacity onPress={() => sendTextHandler()}>
                    <Ionicons name="send" size={24} color="darkgreen" />
                </TouchableOpacity>
            </View>
            
        </View>
    );
}

const styles = StyleSheet.create({
    backgroundView: {
        flex: 1,
        alignItems: 'center',
        borderWidth: 1,
        backgroundColor: '#ededed'
    },
    headerText: {
        fontSize: 18,
        paddingVertical: 10,
        color: 'darkgreen'
    },
    messageView: {
        width: '90%',
        alignItems: 'flex-start',
        borderWidth: 3,
        borderColor: 'darkgreen',
        backgroundColor: 'white',
        borderRadius: 10,
        margin: 10,
        padding: 10
    },
    rowView: {
        flexDirection: 'row',
        justifyContent: 'center',
        alignItems: 'center'
    }
});

export default MessagingScreen;