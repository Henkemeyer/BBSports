import React, { useContext, useState } from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createStackNavigator } from '@react-navigation/stack';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { Ionicons } from '@expo/vector-icons';
import { StatusBar } from 'expo-status-bar';

import UserContextProvider, { UserContext } from './src/store/context/user-context';

import TrainingLogScreen from './src/screens/TrainingLogScreen';
import AthleteCalendarScreen from './src/screens/AthleteCalendarScreen';
import AthleteCardioScreen from './src/screens/AthleteCardioScreen';
import AthleteLiftingScreen from './src/screens/AthleteLiftingScreen';
import SettingsScreen from './src/screens/SettingsScreen';
import CoachTeamRosterScreen from './src/screens/CoachTeamRosterScreen';
import CoachCardioScreen from './src/screens/CoachCardioScreen';
import CoachLiftingScreen from './src/screens/CoachLiftingScreen';

import LoginScreen from './src/screens/LoginScreen';
import SignUpScreen from './src/screens/SignUpScreen';
import EquipmentScreen from './src/screens/EquipmentScreen';
import AddEquipmentScreen from './src/screens/AddEquipment';

const TabNav = createBottomTabNavigator();
const StackNav = createStackNavigator();

function LoginStack() {
  return (
    <StackNav.Navigator
      screenOptions={{
        headerTintColor: 'green',
      }}>
      <StackNav.Screen name="Login" component={LoginScreen} />
      <StackNav.Screen name="SignUp" component={SignUpScreen} />
    </StackNav.Navigator>
  );
}

function EquipmentStack() {
  return (
    <StackNav.Navigator
      screenOptions={{
        headerTintColor: 'green',
      }}>
      <StackNav.Screen name="Equip" component={EquipmentScreen} />
      <StackNav.Screen name="AddEquip" component={AddEquipmentScreen} />
    </StackNav.Navigator>
  );
}

function AthleteTab() {
  return (
    <TabNav.Navigator
      screenOptions={({ route }) => ({
        tabBarIcon: ({ focused, color, size }) => {
          let iconName;

          if (route.name === 'Home') {
            iconName = focused ? 'home' : 'home-outline';
          } else if (route.name === 'Cardio') {
            iconName = focused ? 'beer' : 'beer-outline';
          } else if (route.name === 'Timer') {
            iconName = focused ? 'stopwatch' : 'stopwatch-outline';
          } else if (route.name === 'Lifting') {
            iconName = focused ? 'barbell' : 'barbell-outline';
          } else if (route.name === 'Settings') {
            iconName = focused ? 'settings-sharp' : 'settings-outline';
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
      <TabNav.Screen name="Home" component={TrainingLogScreen} />
      <TabNav.Screen name="Cardio" component={AthleteCardioScreen} />
      <TabNav.Screen name="Lifting" component={AthleteLiftingScreen} />
      <TabNav.Screen name="Settings" component={SettingsScreen} />
    </TabNav.Navigator>
  );
}

function AthleteContainerStack() {
  return (
    <StackNav.Navigator
      screenOptions={{
        headerTintColor: 'green',
      }}>
      <StackNav.Screen 
        name="AthleteTab" 
        component={AthleteTab}
        options={{ headerShown: false }} 
      />
      <StackNav.Screen 
        name="EquipmentStack" 
        component={EquipmentStack}
        options={{ headerShown: false }} 
      />
    </StackNav.Navigator>
  );
}

function CoachTab() {
  return (
    <TabNav.Navigator
      screenOptions={({ route }) => ({
        tabBarIcon: ({ focused, color, size }) => {
          let iconName;

          if (route.name === 'Home') {
            iconName = focused ? 'home' : 'home-outline';
          } else if (route.name === 'Cardio') {
            iconName = focused ? 'beer' : 'beer-outline';
          } else if (route.name === 'Timer') {
            iconName = focused ? 'stopwatch' : 'stopwatch-outline';
          } else if (route.name === 'Lifting') {
            iconName = focused ? 'barbell' : 'barbell-outline';
          } else if (route.name === 'Settings') {
            iconName = focused ? 'settings-sharp' : 'settings-outline';
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
      <TabNav.Screen name="Home" component={CoachTeamRosterScreen} />
      <TabNav.Screen name="Cardio" component={CoachCardioScreen} />
      <TabNav.Screen name="Lifting" component={CoachLiftingScreen} />
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
        ) :
        userCtx.userType=='Athlete' ?  (
          <AthleteContainerStack />
        ) : (
          <CoachTab />
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