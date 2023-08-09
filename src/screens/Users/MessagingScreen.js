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
                <TouchableOpacity key={index} onPress={() => enterChatHandler(index, item)}>
                    <Text key={index}>{item}</Text>
                </TouchableOpacity> 
              ));
            setRenderedItems(roomItems);
        }
        getChatRooms();
    }, []);
 

    function enterChatHandler(index, item) {
        console.log(index+" - "+item);
        navigation.navigate('ChatRoom', {id: index, roomName:item})
    }

    return (
        <View style={styles.containerView}>
            <Text>Testing</Text>
            {renderedItems}
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
    }
});

export default MessagingScreen;