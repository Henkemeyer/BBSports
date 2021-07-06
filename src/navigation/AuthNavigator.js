import React from 'react';
import { createStackNavigator } from '@react-navigation/stack';

import LoginScreen from '../screens/LoginScreen';
import SignUpScreen from '../screens/SignUpScreen';

const AuthNavigator = createStackNavigator();

export const AuthStack = () => {
  return (
  <AuthNavigator.Navigator 
      initialRouteName="SignUp"
      screenOptions={{ animationEnabled: false }}
      headerMode='none'
    >
      <AuthNavigator.Screen name="Login" component={LoginScreen} />
      <AuthNavigator.Screen name="SignUp" component={SignUpScreen} />
    </AuthNavigator.Navigator>
  );
}

// export default AuthStack;