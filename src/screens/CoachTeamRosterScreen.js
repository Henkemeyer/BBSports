import React, { useContext, useEffect, useState } from 'react';
import { FlatList, Modal, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import { UserContext } from '../store/context/user-context';
import { fetchRoster } from '../util/http';

const CoachTeamRosterScreen = () => {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;                  // User Auth Token
    const [getAthletes, setAthletes] = useState([]);
    const [modalVisible, setModalVisible] = useState(false);

    // useEffect(() => {
    //     async function getAthletes() {
    //         const dbAthletes = await fetchRoster(userCtx.userId, token);
    //         setAthletes(dbAthletes);
    //     }
    
    //     getAthletes();
    // }, [token]);

    return (
        <View style={styles.container}>
            <Modal
                animationType="slide"
                transparent={true}
                visible={modalVisible}
                onRequestClose={() => {
                    setModalVisible(!modalVisible);
                }}
            />
            <Text style={styles.orgTitle}>{userCtx.organization ? userCtx.organization.name : 'No Org Selected'}</Text>
            <Text style={styles.rosterHeader}>Athletes</Text>
            {/* <FlatList 
                data={getAthletes}
                renderItem={renderItem}
                keyExtractor={(item) => item.id }
            /> */}
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        margin: 20,
        paddingTop: 10
    },
    orgTitle: {
        borderTopWidth: 5,
        borderColor: 'darkgreen',
        width: '80%',
        fontSize: 30,
        fontWeight: 'bold',
        margin: 15,
        paddingTop: 10,
        color: 'darkgreen',
        textAlign: 'center'
    },
    rosterHeader: {
        borderTopWidth: 3,
        borderColor: 'darkgreen',
        width: '80%',
        fontSize: 20,
        fontWeight: 'bold',
        margin: 5,
        paddingTop: 10,
        color: 'darkgreen',
        textAlign: 'center'
    },
    rosterRow: {
        flexDirection: 'row',
    }
});

export default CoachTeamRosterScreen;