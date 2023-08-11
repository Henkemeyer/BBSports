import React, { useEffect } from 'react';
import { View, ActivityIndicator, StyleSheet } from 'react-native';
import { useDispatch } from 'react-redux';
import { Context as AuthContext } from '../context/AuthContext';
import AsyncStorage from '@react-native-async-storage/async-storage';

// import * as authActions from '../store/actions/auth';

const WelcomeScreen = props => {
  const dispatch = useDispatch();
  const { state, autologin } = useContext(AuthContext);

  useEffect(() => {
    const tryLogin = async () => {
      const token = await AsyncStorage.getItem('token');
      if (!token) {
        // props.navigation.navigate('Login');
        return;
      }
    //   const transformedData = JSON.parse(userData);
    //   const { token, userId, expiryDate } = transformedData;
    //   const expirationDate = new Date(expiryDate);

    //   if (expirationDate <= new Date() || !token || !userId) {
    //     props.navigation.navigate('Auth');
    //     return;
    //   }

    //   const expirationTime = expirationDate.getTime() - new Date().getTime();

    //   props.navigation.navigate('TabStack');
      autologin({token});
    };

    tryLogin();
  }, [dispatch]);

  return (
    <View style={styles.backgroundView}>
      <ActivityIndicator size="large" color='green' />
    </View>
  );
};

const styles = StyleSheet.create({
    backgroundView: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center'
  }
});

export default WelcomeScreen;