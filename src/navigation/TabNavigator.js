import React from 'react';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { createStackNavigator } from '@react-navigation/stack';
import { Ionicons } from '@expo/vector-icons';

import ProfileScreen from '../screens/ProfileScreen';
import TrainingLogScreen from '../screens/TrainingLogScreen';
import TimerScreen from '../screens/TimerScreen';
import SettingsScreen from '../screens/SettingsScreen';
import PracticeScreen from '../screens/PracticeScreen';

const SettingsNavigator = createStackNavigator();

const SettingsStack = () => {
  return (
  <SettingsNavigator.Navigator 
      initialRouteName="Settings"
      screenOptions={{ animationEnabled: false }}
    >
      <SettingsNavigator.Screen name="Settings" component={SettingsScreen} />
      <SettingsNavigator.Screen name="Profile" component={ProfileScreen} />
    </SettingsNavigator.Navigator>
  );
}


const Tab = createBottomTabNavigator();

export const TabStack = () => {
  return (
    <Tab.Navigator
      screenOptions={({ route }) => ({
        tabBarIcon: ({ focused, color, size }) => {
          let iconName;

          if (route.name === 'Home') {
            iconName = focused ? 'home' : 'home-outline';
          }  else if (route.name === 'Test') {
            iconName = focused ? 'beer' : 'beer-outline';
          } else if (route.name === 'Timer') {
            iconName = focused ? 'stopwatch' : 'stopwatch-outline';
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
      <Tab.Screen name="Home" component={PracticeScreen} />
      <Tab.Screen name="Test" component={TrainingLogScreen} />
      <Tab.Screen name="Timer" component={TimerScreen} />
      <Tab.Screen name="Settings" component={SettingsStack} />
    </Tab.Navigator>
  );
}