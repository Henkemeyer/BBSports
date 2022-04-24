import React, {createContext, useState } from 'react';
import AsyncStorage from '@react-native-async-storage/async-storage';

export const UserContext = createContext({
    userId: 0,
    token: null,
    isVIP: false,
    login: (userId) => {},
    logout: () => {},
    userType: '', // Athlete, Coach, Fan?
    switchUserType: (input) => null,
});

function UserContextProvider({children}) {
    const [getUserId, setUserId] = useState([]);
    const [getToken, setToken] = useState([]);
    const [getUserType, setUserType] = useState([]);

    function login(token) {
        setToken(token);
        setUserType('Athlete');
        setUserId('1');
        AsyncStorage.setItem('authToken', token);
    }

    function logout() {
        setToken(null);
        setUserId(0);
        AsyncStorage.removeItem('authToken');
    }

    function switchUserType(input) {
        setUserType(input);
    }

    const value = {
        userId: getUserId,
        token: getToken,
        isVIP: !!getToken,
        login: login,
        logout: logout,
        userType: getUserType,
        switchUserType: switchUserType
    }

    return <UserContext.Provider value={value}>{children}</UserContext.Provider>
}

export default UserContextProvider;