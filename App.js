import React from 'react';
import { NavigationContainer, NavigationContext } from '@react-navigation/native';
import { createStackNavigator } from '@react-navigation/stack';

import LoginScreen from './src/screens/LoginScreen';
import IndexScreen from './src/screens/IndexScreen';
import ProfileScreen from './src/screens/ProfileScreen';

import { UserProvider } from './src/context/UserContext';

const Stack = createStackNavigator();
const isLoggedIn = true;

export default function RootStack() {
  return (
    <NavigationContainer>
      <Stack.Navigator>
        {isLoggedIn ? (
          <>
            <Stack.Screen
              name="Index"
              component={IndexScreen}
              options={{ title: 'My app' }}
            />
            <Stack.Screen
              name="Profile"
              component={ProfileScreen}
              options={{ title: 'BB Sports' }}
              initialParams={{ user: 'me' }}
            />
          </>
        ) : (
          <Stack.Screen name="Login" 
            component={LoginScreen}
            options={{ title: 'BB Sports Login' }} />
        )}
      </Stack.Navigator>
    </NavigationContainer>
  );
}

// export default () => {
//   return <UserProvider>
//     <RootStack />
//   </UserProvider>
// }