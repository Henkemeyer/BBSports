import React, { useState } from 'react';
import { Provider as AuthProvider } from './src/context/AuthContext';
// import { createStore, combineReducers, applyMiddleware } from 'redux';
// import { Provider } from 'react-redux';
// import { AppLoading } from 'expo';
// import * as Font from 'expo-font';
// import ReduxThunk from 'redux-thunk';

//Testing Screen
import LoginScreen from './src/screens/LoginScreen';

import NavigationWrap from './src/navigation/NavigationWrap';

// const rootReducer = combineReducers({
//   products: productsReducer,
//   cart: cartReducer,
//   orders: ordersReducer,
//   auth: authReducer
// });

// const store = createStore(rootReducer, applyMiddleware(ReduxThunk));

// AsyncStorage.getItem('jwtToken').then((token)

const fetchToken = () => {
  return false;
};

export default function App() {
  const [token, setToken] = useState(false);

  // if (!token) {
  //   return (
  //     <AppLoading
  //       startAsync={fetchToken}
  //       onFinish={() => {
  //         setToken(true);
  //       }}
  //     />
  //   );
  // }
  return (
    <AuthProvider>
      <LoginScreen/>
      {/* <NavigationWrap /> */}
    </AuthProvider>
  );
}