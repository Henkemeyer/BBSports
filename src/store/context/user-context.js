import React, {createContext, useState } from 'react';
import AsyncStorage from '@react-native-async-storage/async-storage';

export const UserContext = createContext({
    userId: 0,
    token: null,
    login: (authData) => {},
    logout: () => {},
    userType: '', // Athlete, Coach, Fan?
    switchUserType: (input) => null,
    organization: [],
    switchOrganization: (orgId, admin) => null
});

function UserContextProvider({children}) {
    const [getUserId, setUserId] = useState([]);
    const [getToken, setToken] = useState([]);
    const [getUserType, setUserType] = useState([]);
    const [getOrganization, setOrganization] = useState([]);

    function login(authData) {
        setToken(authData.idToken);
        setUserType('Coach');
        setUserId(authData.localId);
        AsyncStorage.setItem('authToken', authData.idToken);
        AsyncStorage.setItem('userID', authData.localId);
    }

    function logout() {
        setToken(null);
        setUserId(0);
        AsyncStorage.removeItem('authToken');
    }

    function switchUserType(input) {
        setUserType(input);
    }

    function switchOrganization(orgData) {
        setOrganization(orgData);
    }

    const value = {
        userId: getUserId,
        token: getToken,
        userType: getUserType,
        organization: getOrganization,
        login: login,
        logout: logout,
        switchUserType: switchUserType,
        switchOrganization: switchOrganization
    }

    return <UserContext.Provider value={value}>{children}</UserContext.Provider>
}

export default UserContextProvider;