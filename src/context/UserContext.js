import React from 'react';

const UserContext = React.createContext();

export const UserProvider = ({ children }) => {
    return <UserContext.Provider value = {1}> {children} </UserContext.Provider>;
};

export default UserContext;