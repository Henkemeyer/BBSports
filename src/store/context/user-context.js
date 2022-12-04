import React, {createContext, useState } from 'react';
import AsyncStorage from '@react-native-async-storage/async-storage';

export const UserContext = createContext({
    userId: 0,
    token: null,
    name: '',
    fullName: '',
    login: (authData) => {},
    logout: () => {},
    userMode: '', // Athlete, Coach, Fan?
    switchUserMode: (input) => null,
    organizationId: null,
    organizationName: '',
    switchOrganization: (orgData) => {},
    teamId: null,
    teamName: '',
    switchTeam: (teamData) => {}
});

function UserContextProvider({children}) {
    const [getUserId, setUserId] = useState([]);
    const [getToken, setToken] = useState([]);
    const [getUserMode, setUserMode] = useState([]);
    const [getName, setName] = useState([]);
    const [getFullName, setFullName] = useState([]);
    const [getOrganizationId, setOrganizationId] = useState([]);
    const [getTeamId, setTeamId] = useState([]);
    const [getOrganizationName, setOrganizationName] = useState([]);
    const [getTeamName, setTeamName] = useState([]);

    function login(authData) {
        setToken(authData.idToken);
        setUserId(authData.localId);
        AsyncStorage.setItem('authToken', authData.idToken);
        AsyncStorage.setItem('userID', authData.localId);
    }

    function logout() {
        setToken(null);
        setUserId(0);
        AsyncStorage.getAllKeys()
        .then(keys => AsyncStorage.multiRemove(keys))
        .then(() => alert('Logout Success'));
    }

    function switchUserMode(input) {
        setUserMode(input);
        AsyncStorage.setItem('lastUserMode', input);
    }

    function switchOrganization(orgData) {
        if(orgData) {
            setOrganizationId(orgData.id);
            setOrganizationName(orgData.name);
            AsyncStorage.setItem('lastOrgId', orgData.id);
            AsyncStorage.setItem('lastOrgName', orgData.name);
        }
    }

    function switchTeam(teamData) {
        if(teamData) {
            setTeamId(teamData.id);
            setTeamName(teamData.name);
            AsyncStorage.setItem('lastTeamId', teamData.id);
            AsyncStorage.setItem('lastTeamName', teamData.name);
        }
    }

    const value = {
        userId: getUserId,
        token: getToken,
        name: getName,
        fullName: getFullName,
        userMode: getUserMode,
        organizationId: getOrganizationId,
        organizationName: getOrganizationName,
        teamId: getTeamId,
        teamName: getTeamName,
        login: login,
        logout: logout,
        switchUserMode: switchUserMode,
        switchOrganization: switchOrganization,
        switchTeam: switchTeam
    }

    return <UserContext.Provider value={value}>{children}</UserContext.Provider>
}

export default UserContextProvider;