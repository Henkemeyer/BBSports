import React, {createContext, useState } from 'react';
import AsyncStorage from '@react-native-async-storage/async-storage';

export const UserContext = createContext({
    userId: 0,
    token: null,
    name: '',
    fullName: '',
    login: (authData) => {},
    logout: () => {},
    userType: '', // Athlete, Coach, Fan?
    switchUserType: (input) => null,
    organization: null,
    switchOrganization: (orgData) => {}
});

function UserContextProvider({children}) {
    const [getUserId, setUserId] = useState([]);
    const [getToken, setToken] = useState([]);
    const [getUserType, setUserType] = useState([]);
    const [getName, setName] = useState([]);
    const [getFullName, setFullName] = useState([]);
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
        AsyncStorage.removeItem('userID');
        AsyncStorage.removeItem('lastOrg');
        AsyncStorage.removeItem('lastTeam');
        AsyncStorage.removeItem('lastUserType');
    }

    function switchUserType(input) {
        setUserType(input);
        AsyncStorage.setItem('lastUserType', input);
    }

    function switchOrganization(orgData) {
        console.log(orgData.id);
        setOrganization(orgData);
        AsyncStorage.setItem('lastOrg', orgData.id);
    }

    const value = {
        userId: getUserId,
        token: getToken,
        name: getName,
        fullName: getFullName,
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