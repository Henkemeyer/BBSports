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
            const messages = dbMessages.map((item, index) => (
                <View style={styles.messageView}>
                    <Text key={index}>{item.from} {item.time}{'\n'}{item.text}</Text>
                </View>
              ));
            setRenderedMessages(messages);
        }
        getMessages();
    }, []);

    function sendTextHandler() {
        console.log(userCtx.name+" - "+inputText);
        const newMessage = [{
            "from": userCtx.name, 
            "text": inputText,
            "time": new Date()
        }]
        postMessage(newMessage);
    }

    return (
        <View style={styles.containerView}>
            <Text>{chatRoom.roomName}</Text>
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
        justifyContent: 'center',
        borderWidth: 1,
        backgroundColor: '#ededed'
    },
    containerView: {
        flex: 1,
        alignItems: 'center',
        borderWidth: 1,
        borderColor: 'gray',
        backgroundColor: '#ffffff',
        borderRadius: 10,
        margin: 10,
    },
    messageView: {
        width: '90%',
        alignItems: 'flex-start',
        borderWidth: 2,
        borderColor: 'gray',
        backgroundColor: '#darkgreen',
        borderRadius: 10,
        margin: 10,
        padding: 10
    },
    rowView: {
        flexDirection: 'row',
    }
});

export default MessagingScreen;