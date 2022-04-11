import React, {createContext, useState } from 'react';

export const UserContext = createContext({
    userId: '',
    token: '',
    isVIP: false,
    login: (userId) => {},
    logout: () => {},
    // userType: 'Fan', // Athlete, Coach, Fan
    // switchUserType: (occupation) => null,
});

function UserContextProvider({children}) {
    const [getUserId, setUserId] = useState([]);
    const [getToken, setToken] = useState();

    function login(userId) {
        setToken('69');
        setUserId(userId);
    }

    function logout() {
        setToken('');
        setUserId('');
    }

    // function switchUserType(input) {
    //     setUserType((currentUserType) => input);
    // }

    const value = {
        userId: getUserId,
        token: getToken,
        isVIP: !!getToken,
        login: login,
        logout: logout,
        // userType: getUserType,
        // switchUserType: switchUserType
    }

    return <UserContext.Provider value={value}>{children}</UserContext.Provider>
}

export default UserContextProvider;