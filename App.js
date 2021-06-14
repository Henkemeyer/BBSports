import React, { Component } from 'react';
import { NavigationContainer, NavigationContext } from '@react-navigation/native';
import { createStackNavigator } from '@react-navigation/stack';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { Ionicons } from '@expo/vector-icons';
import AsyncStorage from '@react-native-async-storage/async-storage';

import LoginScreen from './src/screens/LoginScreen';
import SignUpScreen from './src/screens/SignUpScreen';
import ProfileScreen from './src/screens/ProfileScreen';
import SettingsScreen from './src/screens/SettingsScreen';
import TrainingLogScreen from './src/screens/TrainingLogScreen';
import PracticeScreen from './src/screens/PracticeScreen';
import LiftingScreen from './src/screens/LiftingScreen';
import IndexScreen from './src/screens/IndexScreen';
import TimerScreen from './src/screens/TimerScreen';

import { AuthProvider } from './src/context/AuthContext';

/*
const containerNavigator = NavigationContainer({
  AuthStack: createStackNavigator({
    SignUp: SignUpScreen,
    Login: LoginScreen
  }),
  mainStack: createBottomTabNavigator({
    trainingStack: createStackNavigator({
      TrainingLog: TrainingLogScreen
    }),
    workoutStack: createStackNavigator({
      Practice: PracticeScreen,
      Lifting: LiftingScreen
    }),
    recordingStack: createStackNavigator({
      Timing: TimerScreen
    }),
    settingsStack: createStackNavigator({
      Settings: SettingsScreen,
      Profile: ProfileScreen
    })
  })
});
*/
const ContainerStack = createStackNavigator();
const Authentication = createStackNavigator();

function AuthStack() {
  return (
  <Authentication.Navigator 
      initialRouteName="Login"
      screenOptions={{ animationEnabled: false }}
      headerMode='none'
    >
      <Authentication.Screen name="Login" component={LoginScreen} />
      <Authentication.Screen name="SignUp" component={SignUpScreen} />
    </Authentication.Navigator>
  );
}

const Tab = createBottomTabNavigator();

function TabStack() {
  return (
    <NavigationContainer>
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
        <Tab.Screen name="Home" component={ProfileScreen} />
        <Tab.Screen name="Test" component={TrainingLogScreen} />
        <Tab.Screen name="Timer" component={TimerScreen} />
        <Tab.Screen name="Settings" component={SettingsScreen} />
      </Tab.Navigator>
    </NavigationContainer>
  );
}


class App extends Component {
  constructor() {
    super();
    this.state = {
      // loading: true,
      hasToken: false,
    };
  }
 
  componentDidMount(){
    AsyncStorage.getItem('jwtToken').then((token) => {
      this.setState({ hasToken: token !== null//,loading:false
      })
    })
  }

  render() {
    const {hasToken} = this.state;
    
  //   if (loading) {
  //     return <WelcomeScreen/>
  //   } 
  //  else  {
    return( 
      <NavigationContainer>
        <ContainerStack.Navigator headerMode="none">
          { !hasToken 
            ? <ContainerStack.Screen name='Auth' component={AuthStack}/>
            : <ContainerStack.Screen name='App' component={TabStack}/>
          }
        </ContainerStack.Navigator>
      </NavigationContainer>
    );
  }
}

export default App;

/*
const App = createAppContainer(containerNavigator);

export default () => {
  return (
    <AuthProvider>
      <App />
    </AuthProvider>
  )
}; */