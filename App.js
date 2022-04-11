import React, { useContext, useState } from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createStackNavigator } from '@react-navigation/stack';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { Ionicons } from '@expo/vector-icons';
import { StatusBar } from 'expo-status-bar';

import UserContextProvider, { UserContext } from './src/store/context/user-context';

import TrainingLogScreen from './src/screens/TrainingLogScreen';
import LiftingScreen from './src/screens/LiftingScreen';
import SettingsScreen from './src/screens/SettingsScreen';
import PracticeScreen from './src/screens/PracticeScreen';

import LoginScreen from './src/screens/LoginScreen';
import SignUpScreen from './src/screens/SignUpScreen';

const TabNav = createBottomTabNavigator();
const LoginNav = createStackNavigator();

function LoginStack() {
  return (
    <LoginNav.Navigator
      screenOptions={{
        headerTintColor: 'green',
      }}>
      <LoginNav.Screen name="Login" component={LoginScreen} />
      <LoginNav.Screen name="SignUp" component={SignUpScreen} />
    </LoginNav.Navigator>
  );
}

function LoggedInTab() {
  return (
    <TabNav.Navigator
      screenOptions={({ route }) => ({
        tabBarIcon: ({ focused, color, size }) => {
          let iconName;

          if (route.name === 'Home') {
            iconName = focused ? 'home' : 'home-outline';
          } else if (route.name === 'Test') {
            iconName = focused ? 'beer' : 'beer-outline';
          } else if (route.name === 'Timer') {
            iconName = focused ? 'stopwatch' : 'stopwatch-outline';
          } else if (route.name === 'Lifting') {
            iconName = focused ? 'barbell' : 'barbell-outline';
          } else if (route.name === 'Settings') {
            iconName = focused ? 'settings-sharp' : 'settings-outline';
          } else if (route.name === 'Login') {
            iconName = focused ? 'enter' : 'enter-outline';
          } else if (route.name === 'SignUp') {
            iconName = focused ? 'create' : 'create-outline';
          }

          // You can return any component that you like here!
          return <Ionicons name={iconName} size={size} color={color} />;
        },
      })}
      tabBarOptions={{
        activeTintColor: 'green',
        inactiveTintColor: 'black',
      }}
    >
      <TabNav.Screen name="Home" component={PracticeScreen} />
      <TabNav.Screen name="Test" component={TrainingLogScreen} />
      <TabNav.Screen name="Lifting" component={LiftingScreen} />
      <TabNav.Screen name="Settings" component={SettingsScreen} />
    </TabNav.Navigator>
  );
}

function Navigation () {
    const userCtx = useContext(UserContext);

    return (
      <NavigationContainer>
        {userCtx.userId==0 ? (
          <LoginStack />
        ) : (
          <LoggedInTab />
        )}
      </NavigationContainer>
    );
}

export default function App(){
  return(
    <>
      {/* <StatusBar style="light" /> */}
      <UserContextProvider>
        <Navigation />
      </UserContextProvider>
    </>
  );
};