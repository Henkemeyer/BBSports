import React, { useContext, useState } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import OurButton from '../components/OurButton';
import UserInput from '../components/UserInput';
import ShadowBox from '../components/ShadowBox';
import { UserContext } from '../store/context/user-context';
import { fetchUser, postCoach } from '../util/http';

const AddCoachScreen = ({ navigation }) => {
    const userCtx = useContext(UserContext);
    const [uid, setUid] = useState('');
    const [coach, setCoach] = useState([]);
    const [title, setTitle] = useState('');

    function searchHandler() {
        fetchUser(uid, userCtx.token).then(function (response) {
            console.log(response)
            setCoach(response.data);
        })
        .catch(function (error) {
            console.log(error);
        });
    }
    
    function submitHandler() {
        const coachData = {
            uid: userCtx.userId,
            fullName: coach.fullName,
            title: title,
            status: 'P' // (P)ending, (A)ctive, (T)erminated
            //role: 'Head' // Head, Assist, Circuit
        }
        postCoach(coachData, userCtx.token);
        navigation.navigate("Organization");
    }

    return (
        // <View style={styles.container}>
        <ShadowBox style={styles.container}>
            <UserInput
                label="User ID"
                value={uid}
                onChangeText={setUid}
            />
            <OurButton
                buttonPressed={() => searchHandler()}
                buttonText="Search"
            />
            { uid ? <>
                <Text style={styles.text}>Name: {coach.fullName}</Text>
                <Text style={styles.text}>Location: {coach.location}</Text>
                <UserInput
                    label="Title"
                    value={title}
                    onChangeText={setTitle}
                />
                <OurButton
                    buttonPressed={() => submitHandler()}
                    buttonText="Hire"
                />
            </> : null}
        </ShadowBox>
        // </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
        margin: 30,
        justifyContent: 'space-around'
    },
    text: {
        fontSize: 30,
        fontWeight: 'bold',
        margin: 15,
        color: 'darkgreen'
    }
});

export default AddCoachScreen;