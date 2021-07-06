import AsyncStorage from '@react-native-async-storage/async-storage';
import CreateContext from "./CreateContext";
import mongoApi from '../api/mongo';

const initialState = {
    token: null,
    userId: null,
    errorMessage: '',
    loading: true
  };

const authReducer = (state, action) => {
    switch (action.type) {
        case 'add_error':
            return { ...state, errorMessage: action.payload };
        case 'signup':
            return { errorMessage: '', token: action.payload };
        case 'signin':
                return { errorMessage: '', token: action.payload, loading: false };
        case 'signout':
            return { ...initialState };
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
        dispatch({ 
            type: 'add_error', 
            payload: 'Something went wrong during signup' 
        });
    }
};

const autologin = (dispatch) => async ({ token }) => {
    try {
        dispatch({ type: 'signin', payload: token });
    } 
    catch (err) {
        dispatch({ 
            type: 'add_error', 
            payload: 'Something went wrong while signing in' 
        });
    }
};

const signin = (dispatch) => async ({ email, password }) => {
    try {
        const response = await mongoApi.post('/signin', { email, password });
        await AsyncStorage.setItem('token', response.data.token);
        dispatch({ type: 'signin', payload: response.data.token });
    } 
    catch (err) {
        dispatch({ 
            type: 'add_error', 
            payload: 'Something went wrong while signing in' 
        });
    }
};

const signout = (dispatch) => async () => {
    try {
        await AsyncStorage.removeItem('token');
        dispatch({ type: 'signout' });
    } 
    catch (err) {
        dispatch({ 
            type: 'add_error', 
            payload: 'Something went wrong while signing out' 
        });
    }
};

export const { Provider, Context } = CreateContext(
    authReducer,
    { autologin, signin, signout, signup},
    { ...initialState }
);