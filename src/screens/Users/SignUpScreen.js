import React, { useContext, useState } from 'react';
import { Alert, Keyboard, ScrollView, StyleSheet, Text, TouchableOpacity, TouchableWithoutFeedback, View } from 'react-native';
import DateTimePicker from '@react-native-community/datetimepicker';
import { format } from 'date-fns';
import SelectDropdown from 'react-native-select-dropdown';
import { Ionicons } from '@expo/vector-icons';
import UserInput from '../../components/UserInput';
import ShadowBox from '../../components/ShadowBox';
import OurButton from '../../components/OurButton';
import { UserContext } from '../../store/context/user-context';
import { authenticate } from '../../util/auth';
import { postUser } from '../../util/http';

function SignUpScreen({ navigation }) {
    const userCtx = useContext(UserContext);
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [passwordQC, setPasswordQC] = useState('');
    const [firstName, setFirstName] = useState('');
    const [nickname, setNickname] = useState('');
    const [mode, setMode] = useState('Athlete');
    // Error Messages
    const [emailError, setEmailError] = useState('');
    const [passwordError, setPWError] = useState('');
    const [nameError, setNameError] = useState('');
    const [isValid, setIsValid] = useState(false);

    const confirmInputAgent = () => {
        setIsValid(true);
        if(email.length < 4) {
            setEmailError('*You must enter a valid Email');
            setIsValid(false);
        }
        if(password.length < 8) {
            setPWError('*Password must be at least 8 characters');
            setIsValid(false);
        } else if(!/[\d\W]/.test(password)) {
            setPWError('*Passwords must contain a number or special character');
            setIsValid(false);
        } else if(password !== passwordQC) {
            setPWError('*Passwords do not match');
            setIsValid(false);
        }
        if(firstName.length < 2 && nickname.length < 2) {
            setNameError('*You must enter a name or nickname');
            setIsValid(false);
        }
        if(isValid) {
            signUpHandler();
        }
    };

    async function signUpHandler() {
        try {
            const authData = await authenticate('signUp', email, password);
            const userData = 
                {
                    uid: authData.localId,
                    firstName: firstName,
                    nickname: nickname,
                    email: email,
                    mode: mode
                }

            postUser(userData, authData.idToken)
            userCtx.signUp(authData, userData);
        } catch (error) {
            Alert.alert('Sign Up Failed!', 'Failed to sign up. Please check E-mail and Password.')
        }
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
                        <Text style={styles.headerText}>Coaches Log</Text>
                        <Text style={styles.headerText}>Sign Up</Text>
                            <View style={styles.inputView}>
                                <UserInput
                                    label="Email"
                                    value={email.trim()}
                                    onChangeText={setEmail}
                                    autoCapitalize="none"
                                    autoCorrect={false}
                                />
                        </View>
                        { emailError ? <Text style={styles.errorText}>{emailError}</Text> : null }

                        <View style={styles.inputView}>
                            <UserInput
                                secureTextEntry
                                label="Password"
                                value={password}
                                onChangeText={setPassword}
                                autoCapitalize="none"
                                autoCorrect={false}
                            />
                        </View>
                        { passwordError ? <Text style={styles.errorText}>{passwordError}</Text> : null }
                        <View style={styles.inputView}>
                            <UserInput
                                secureTextEntry
                                label="Re-Enter Password"
                                value={passwordQC}
                                onChangeText={setPasswordQC}
                                autoCapitalize="none"
                                autoCorrect={false}
                            />
                        </View>

                        <View style={styles.inputView}>
                            <UserInput
                                label="First Name"
                                value={firstName}
                                onChangeText={setFirstName}
                                autoCorrect={false}
                            />
                        </View>
                        { nameError ? <Text style={styles.errorText}>{nameError}</Text> : null }

                        <View style={styles.inputView}>
                            <UserInput
                                label="Nickname"
                                value={nickname}
                                onChangeText={setNickname}
                                autoCorrect={false}
                            />
                        </View>
                        <View>
                            <Text style={styles.selectText}>Primary Role</Text>
                            <SelectDropdown
                                data={["Athlete","Coach"]}
                                onSelect={(selectedItem, index) => {
                                    setMode(selectedItem.substring(0,1))
                                }}
                                defaultButtonText="Athlete"
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
                        <OurButton
                            buttonPressed={confirmInputAgent}
                            buttonText="Create Account"
                            style={styles.loginButton}
                        />
                        <TouchableOpacity onPress={() => navigation.navigate('Login')}>
                            <Text style={styles.clickText}>Already have an account?</Text>
                        </TouchableOpacity>
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
        marginVertical: 40,
        width: '85%'
    },
    headerText: {
        fontSize: 30,
        fontWeight: 'bold',
        margin: 15,
        color: 'darkgreen'
    },
    inputView: {
        width: 250,
        marginBottom: 20
    },
    lengthRow: {
        flexDirection: 'row',
        paddingVertical: 10,
        alignItems: 'center'
    },
    selectText: {
        fontSize: 18,
        textAlign: 'left',
        marginRight: '2%',
        color: 'darkgreen'
    },
    loginButton: {
        marginVertical: 20,
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
    selectDropDownButton: {
        width: '80%',
        height: 40,
        marginVertical: 15,
        backgroundColor: 'darkgreen',
        borderRadius: 8,
        alignSelf: 'center',
        alignContent: 'center'
    },
    selectDropDown: {
        backgroundColor: 'darkgreen',
        borderBottomLeftRadius: 12,
        borderBottomRightRadius: 12,
    },
    selectDropDownRow: {
        backgroundColor: 'darkgreen', 
        borderBottomColor: '#C5C5C5',
    },
    selectDropDownText: {
        color: '#FFF',
        textAlign: 'center',
        fontWeight: 'bold'
    }
});

export default SignUpScreen;