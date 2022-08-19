import React, { useContext, useState } from 'react';
import { StyleSheet, Text, TouchableWithoutFeedback } from 'react-native';
import OurButton from '../components/OurButton';
import UserInput from '../components/UserInput';
import ShadowBox from '../components/ShadowBox';
import { UserContext } from '../store/context/user-context';
import { fetchUser, postAthlete } from '../util/http';

const AddAthlete = ({ navigation }) => {
    const userCtx = useContext(UserContext);
    const [uid, setUid] = useState('');
    const [athlete, addAthlete] = useState([]);
    const [title, setTitle] = useState('');

    function searchHandler() {
        fetchUser(uid, userCtx.token).then(function (response) {
            console.log(response)
        })
        .catch(function (error) {
            console.log(error);
        });
    }
    
    function submitHandler() {
        const athleteData = {
            uid: userCtx.userId,
            fullName: athlete.fullName,
            status: 'P' // (P)ending, (A)ctive, (T)erminated
            //role: 'Head' // Head, Assist, Circuit
        }
        postAthlete(athleteData, userCtx.token);
        navigation.navigate("Team");
    }

    return (
        <TouchableWithoutFeedback
            onPress={() =>{
                Keyboard.dismiss();
            }}
        >
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
                    <Text style={styles.text}>Name: {athlete.fullName}</Text>
                    <Text style={styles.text}>Location: {athlete.location}</Text>
                    <UserInput
                        label="Title"
                        value={title}
                        onChangeText={setTitle}
                    />
                    <OurButton
                        buttonPressed={() => submitHandler()}
                        buttonText="Recruit"
                    />
                </> : null}
            </ShadowBox>
        </TouchableWithoutFeedback>
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

export default AddAthleteScreen;