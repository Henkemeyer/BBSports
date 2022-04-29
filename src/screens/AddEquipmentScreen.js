import React, { useContext, useState } from 'react';
import { StyleSheet, Text, View } from 'react-native';
import OurButton from '../components/OurButton';
import UserInput from '../components/UserInput';
import ShadowBox from '../components/ShadowBox';
import { UserContext } from '../store/context/user-context';
import { postEquipment } from '../util/http';

const AddEquipmentScreen = ({ navigation }) => {
    const userCtx = useContext(UserContext);
    const [name, setName] = useState('');
    const [eDate, setEDate] = useState(new Date());
    const [description, setDescription] = useState('');

    function submitHandler() {
        const equipment = {
            uid: userCtx.userId,
            name: name,
            purchaseDate: new Date(eDate),
            description: description,
            distance: 0,
            retired: false
        }
        postEquipment(equipment, userCtx.token);
        navigation.navigate("Equip");
    }

    return (
        // <View style={styles.container}>
        <ShadowBox style={styles.container}>
            <UserInput
                label="Equipment Name"
                value={name}
                onChangeText={setName}
            />
            {/* <Text></Text> */}
            {/* <UserInput
                label="Purchase Date"
                value={eDate}
                onChangeText={setEDate}
            /> */}
            <UserInput
                label="Equipment Description (Optional)"
                value={description}
                onChangeText={setDescription}
            />
            <OurButton
                buttonPressed={() => submitHandler()}
                buttonText="Submit"
            />
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
});

export default AddEquipmentScreen;