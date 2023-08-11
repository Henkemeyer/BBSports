import React, { useState } from 'react';
import { View, Button, Image, StyleSheet } from 'react-native';
import UploadProfilePicture from '../components/UploadProfilePicture';

const TeamProfileScreen = ({ navigation }) => {
  const [imageUri, setImageUri] = useState(null);


  return (
    <View style={styles.container}>
      <UploadProfilePicture />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: 'center',
    justifyContent: 'center',
  },
  image: {
    width: 200,
    height: 200,
    resizeMode: 'contain',
  },
});

export default TeamProfileScreen;