import React from 'react';
import { useSelector } from 'react-redux';
import { NavigationContainer } from '@react-navigation/native';

import { AuthStack } from './AuthNavigator';
import { TabStack } from './TabNavigator';
import WelcomeScreen from '../screens/WelcomeScreen';

const NavigationBurrito = props => {
    const token = props.token

    return (
        <NavigationContainer>
            {token && <TabStack />}
            {!token && didTryAutoLogin && <AuthStack />}
            {/* {!token && !didTryAutoLogin && <WelcomeScreen />} */}
        </NavigationContainer>
    );
};

export default NavigationBurrito;