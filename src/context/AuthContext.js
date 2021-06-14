import AsyncStorage from '@react-native-async-storage/async-storage';
// import { AsyncStorage } from 'react-native';
import CreateContext from "./CreateContext";
import mongoApi from '../api/mongo';

const authReducer = (state, action,) => {
    switch (action.type) {
        case 'add_error':
            return { ...state, errorMessage: action.payload };
        case 'signup':
            return { errorMessage: '', token: action.payload };
        default:
            return state;
    }
};

const signup = (dispatch) => async ({ email, password }) => {
    try {
        const response = await mongoApi.post('/signup', { email, password });
        await AsyncStorage.setItem('token', response.data.token);
        dispatch({ type: 'signup', payload: response.data.token });
    } 
    catch (err) {
        dispatch({ type: 'add_error', payload: 'Something went wrong during signup' })
    }
};

const signin = (dispatch) => {
    return ({ email, password }) => {
        
    };
};

const signout = (dispatch) => {
    return () => {
        
    };
};

export const { AuthProvider, Context } = CreateContext(
    authReducer,
    { signin, signup, signout},
    { hasToken: false, errorMessage: '' }
);