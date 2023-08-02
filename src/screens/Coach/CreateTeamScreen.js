import React, { useContext, useState } from 'react';
import { Alert, ScrollView, StyleSheet, Text, Keyboard, KeyboardAvoidingView, TouchableWithoutFeedback, View } from 'react-native';
import SelectDropdown from 'react-native-select-dropdown';
import UserInput from '../../components/UserInput';
import ShadowBox from '../../components/ShadowBox';
import OurButton from '../../components/OurButton';
import { UserContext } from '../../store/context/user-context';
import { postTeam } from '../../util/http';
import { Ionicons } from '@expo/vector-icons';

function CreateTeamScreen({ navigation }) {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [teamName, setTeamName] = useState('');
    const [level, setLevel] = useState('');
    const [description, setDescription] = useState('');
    const [sex, setSex] = useState('');
    const [sport, setSport] = useState('');
    const [nameError, setNameError] = useState('');
    const [isValid, setIsValid] = useState(false);
    const sports = [{ id: 1, name: 'Cross Country' }];

    const confirmInputAgent = () => {
        setIsValid(true);
        setNameError('');
        if(teamName.length < 3) {
            setNameError('*You must enter a Team Name');
            setIsValid(false);
        }
        if(isValid) {
            createTeamHandler();
        }
    };

    function createTeamHandler() {
        try {
            const teamData = {
                description: description,
                level: level,
                name: teamName,
                organizationId: userCtx.organization.id,
                sex: 'X',
                sport: sport
            }
            
            postTeam(teamData, token)
        } catch (error) {
            Alert.alert('Team Creation Failed!', 'Failed to create Team. Please try again later')
        }
        navigation.goBack();
    }

    return (
        <TouchableWithoutFeedback
            onPress={() =>{
                Keyboard.dismiss();
            }}
        >
            <ScrollView>
                <View style={styles.backgroundView}>
                    <ShadowBox style={styles.containerView}>
                        <Text style={styles.headerText}>Create a New Team</Text>
                        <SelectDropdown
                            data={sports}
                            onSelect={(selectedItem, index) => {
                                setSport(selectedItem.name);
                            }}
                            defaultButtonText="Sports"
                            buttonTextAfterSelection={(selectedItem, index) => {
                                return selectedItem.name
                            }}
                            rowTextForSelection={(item, index) => {
                                return item.name
                            }}
                            buttonStyle={styles.selectDropDownButton}
                            buttonTextStyle={styles.selectDropDownText}
                            renderDropdownIcon={isOpened => {
                                return <Ionicons name={isOpened ? 'chevron-up-circle-sharp' : 'chevron-down-circle-outline'} color={'#FFF'} size={18} />;
                            }}
                            dropdownIconPosition={'right'}
                            dropdownStyle={styles.selectDropDown}
                            rowStyle={styles.selectDropDownRow}
                            rowTextStyle={styles.selectDropDownText}
                        />
                        <View style={styles.inputView}>
                            <UserInput
                                label="Name"
                                value={teamName}
                                onChangeText={setTeamName}
                                autoCorrect={false}
                            />
                        </View>
                        { nameError ? <Text style={styles.errorText}>{nameError}</Text> : null }
                        <View style={styles.inputView}>
                            <UserInput
                                label="Team Level"
                                value={level}
                                onChangeText={setLevel}
                                autoCorrect={false}
                            />
                        </View>
                        <View>
                            <Text style={styles.selectText}>Sex:</Text>
                            <SelectDropdown
                                data={["X","Male","Female"]}
                                onSelect={(selectedItem, index) => {
                                    setSex(selectedItem.substring(0,1))
                                }}
                                defaultButtonText="Sex"
                                buttonTextAfterSelection={(selectedItem, index) => {
                                    return selectedItem
                                }}
                                rowTextForSelection={(item, index) => {
                                    return item
                                }}
                                buttonStyle={styles.selectDropDownButton}
                                buttonTextStyle={styles.selectDropDownText}
                                renderDropdownIcon={isOpened => {
                                    return <Ionicons name={isOpened ? 'chevron-up-circle-sharp' : 'chevron-down-circle-outline'} color={'#FFF'} size={18} />;
                                }}
                                dropdownIconPosition={'right'}
                                dropdownStyle={styles.selectDropDown}
                                rowStyle={styles.selectDropDownRow}
                                rowTextStyle={styles.selectDropDownText}
                            />
                        </View>
                        <View style={styles.inputView}>
                            <UserInput
                                label="Description"
                                value={description}
                                onChangeText={setDescription}
                                multiline
                                numberOfLines={6}
                            />
                        </View>
                        <OurButton
                            buttonPressed={confirmInputAgent}
                            buttonText="Create Team"
                            style={styles.confirmButton}
                        />
                    </ShadowBox>
                </View>
            </ScrollView>
        </TouchableWithoutFeedback>
    );
}

const styles = StyleSheet.create({
    backgroundView: {
        flex: 1,
        alignItems: 'center',
        borderWidth: 1,
        backgroundColor: '#ededed'
    },
    containerView: {
        flexWrap: 'nowrap',
        alignItems: 'center',
        borderWidth: 1,
        borderColor: 'gray',
        backgroundColor: '#ffffff',
        borderRadius: 10,
        marginVertical: 65,
        width: '80%'
    },
    headerText: {
        fontSize: 30,
        fontWeight: 'bold',
        margin: 15
    },
    inputView: {
        width: 250,
        marginBottom: 20
    },
    confirmButton: {
        marginBottom: 15,
        width: '75%'
    },
    clickText: {
        fontSize: 15,
        color: 'orange',
        marginBottom: 30
    },
    errorText: {
        color: 'red',
        fontSize: 15,
        marginBottom: 15
    },
    selectText: {
        fontSize: 18,
        textAlign: 'left',
        marginHorizontal: '5%',
        color: 'darkgreen'
    },
    selectDropDownButton: {
        width: '80%',
        height: 50,
        backgroundColor: 'darkgreen',
        borderRadius: 8
    },
    selectDropDown: {
        backgroundColor: 'darkgreen',
        borderBottomLeftRadius: 12,
        borderBottomRightRadius: 12
    },
    selectDropDownRow: {
        backgroundColor: 'darkgreen', 
        borderBottomColor: '#C5C5C5'
    },
    selectDropDownText: {
        color: '#FFF',
        textAlign: 'center',
        fontWeight: 'bold'
    },
});

export default CreateTeamScreen;