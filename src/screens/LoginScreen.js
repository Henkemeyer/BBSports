import React, { useState, useContext } from 'react';
import { View, Text, TouchableOpacity, TextInput, StyleSheet } from 'react-native';
import CheckBox from '../components/CheckBox';
import ShadowBox from '../components/ShadowBox';
import Colors from '../constants/ColorThemes';
// import { AuthContext } from '../context/AuthContext';
// import { useNavigation } from '@react-navigation/native';

const LoginScreen = ( navigation ) => {
    // const { state, signin } = useContext(AuthContext);
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [checked, setChecked] = useState(false);

    return (
        <View style={styles.backgroundView}>
            <ShadowBox style={styles.containerView}>
                <Text style={styles.headerText}>Login to BB Sports</Text>
                <View style={styles.inputView}>
                    <Text style={styles.inputText}>E-mail or BBID:</Text>
                    <TextInput 
                        label="Email"
                        value={email}
                        onChangeText={setEmail}
                        autoCapitalize="none"
                        autoCorrect={false}
                        style={styles.inputComp}
                    />
                </View>
                <View style={styles.inputView}>
                <Text style={styles.inputText}>Password:</Text>
                    <TextInput
                        secureTextEntry
                        label="Password"
                        value={password}
                        onChangeText={setPassword}
                        autoCapitalize="none"
                        autoCorrect={false}
                        style={styles.inputComp}
                    />
                </View>
                <View style={styles.rowView}>
                    <CheckBox 
                        toggle={() => setChecked(!checked)}
                        checked={checked}
                    />
                    <Text style={{paddingRight: 28}}>Remember Me</Text>
                    <TouchableOpacity>
                        <Text style={styles.clickText}>Reset Password</Text>
                    </TouchableOpacity>
                </View>
                <TouchableOpacity 
                    onPress={() => setEmail(email)}
                    style={styles.loginButton}>
                    <Text style={styles.buttonText}>Login</Text>
                </TouchableOpacity>
                <TouchableOpacity onPress={() => navigation.navigate('signup')} >
                    <Text style={styles.clickText2}>Create Account?</Text>
                </TouchableOpacity>
            </ShadowBox>
        </View>
    );
};
// AsyncStorage.removeItem('token')

const styles = StyleSheet.create({
    backgroundView: {
        flex: 1,
        alignItems: 'center',
        borderWidth: 1,
        backgroundColor: Colors.tertiary
    },
    containerView: {
        marginVertical: 150
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
    inputText: {
        fontSize: 15,
        color: 'gray',
        marginBottom: 2
    },
    inputComp: {
        backgroundColor: 'white',
        borderWidth: 1,
        borderColor: 'black',
        borderRadius: 5,
        fontSize: 20
    },
    rowView: {
        flexDirection: 'row',
        alignItems: 'center',
        height: 47,
        paddingBottom: 25
    },
    loginButton: {
        borderWidth: 1,
        borderRadius: 5,
        backgroundColor: '#268736',
        height: 40,
        maxWidth:300
    },
    buttonText: {
        fontSize:27,
        fontWeight: 'bold',
        alignSelf:'center',
        marginHorizontal: 5,
        marginBottom: 25
    },
    clickText: {
        fontSize: 15,
        color: 'orange'
    },
    clickText2: {
        fontSize: 15,
        color: 'orange',
        paddingVertical: 25
    }
});

export default LoginScreen;

// class LoginScreen extends React.Component {
//     render() {
//         const { token } = this.props;
//     }
// }

// export default function(props) {
//     const token = useNavigationState(state => state.token);

//     return <LoginScreen {...props} token={token} />;
// }