import React, { useContext, useEffect, useState } from 'react';
import { Alert, FlatList, ScrollView, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import SelectDropdown from 'react-native-select-dropdown';
import OurButton from '../../components/OurButton';
import { UserContext } from '../../store/context/user-context';
import { fetchChatRooms, postChatRoom } from '../../util/http';
import { Ionicons } from '@expo/vector-icons';

function MessagingScreen({ navigation }) {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [chatRooms, setChatRooms] = useState([]);
    const [renderedItems, setRenderedItems] = useState([]);

    useEffect(() => {
        async function getChatRooms() {
            let dbChatRooms = [];
            try {
                const response = await fetchChatRooms(userCtx.userId, token);
                dbChatRooms = response.data;
            } catch (error) {
                console.log(error);
                Alert.alert('Messaging Failed!', 'Failed to fetch messages. '+error)
            }

            const roomItems = dbChatRooms.map((item, index) => (
                <View key={"view"+index} style={styles.listView}>
                    <TouchableOpacity key={"click"+index} onPress={() => enterChatHandler(index, item)}>
                        <Text key={"text"+index}>{item}</Text>
                    </TouchableOpacity> 
                </View>
              ));
            setRenderedItems(roomItems);
        }
        getChatRooms();
    }, []);
 

    function enterChatHandler(index, item) {
        navigation.navigate('ChatRoom', {id: index, roomName:item})
    }

    return (
        <View style={styles.backgroundView}>
            <Text style={styles.headerText}>Your Chat Rooms</Text>
            {renderedItems}
        </View>
    );
}

const styles = StyleSheet.create({
    backgroundView: {
        flex: 1,
        alignItems: 'center',
        // justifyContent: 'center',
        borderWidth: 1,
        backgroundColor: '#ededed'
    },
    listView: {
        alignItems: 'flex-start',
        width: '90%',
        height: '5%',
        borderWidth: 4,
        borderColor: 'darkgreen',
        backgroundColor: 'green',
        borderRadius: 10,
        margin: 10,
        padding: 5
    },
    headerText: {
        fontSize: 18,
        paddingVertical: 10,
        color: 'darkgreen'
    },
    listText: {
        fontSize: 16
    }
});

export default MessagingScreen;