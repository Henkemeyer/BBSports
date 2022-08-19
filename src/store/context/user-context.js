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
    switchOrganization: (orgData) => {},
    team: null,
    switchTeam: (teamData) => {}
});

function UserContextProvider({children}) {
    const [getUserId, setUserId] = useState([]);
    const [getToken, setToken] = useState([]);
    const [getUserType, setUserType] = useState([]);
    const [getName, setName] = useState([]);
    const [getFullName, setFullName] = useState([]);
    const [getOrganization, setOrganization] = useState([]);
    const [getTeam, setTeam] = useState([]);

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

    function switchTeam(teamData) {
        console.log(teamData.id);
        setTeam(teamData);
        AsyncStorage.setItem('lastTeam', teamData.id);
    }

    const value = {
        userId: getUserId,
        token: getToken,
        name: getName,
        fullName: getFullName,
        userType: getUserType,
        organization: getOrganization,
        team: getTeam,
        login: login,
        logout: logout,
        switchUserType: switchUserType,
        switchOrganization: switchOrganization,
        switchTeam: switchTeam
    }

    return <UserContext.Provider value={value}>{children}</UserContext.Provider>
}

export default UserContextProvider;