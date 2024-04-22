import React, { useState, useEffect } from 'react';
import { Image, View, Platform, TouchableOpacity, Text, StyleSheet } from 'react-native';
import { Ionicons } from '@expo/vector-icons';
import * as ImagePicker from 'expo-image-picker';
import storage from '@react-native-firebase/storage';
import * as Progress from 'react-native-progress';

export default function UploadProfilePicture() {
    const [image, setImage] = useState(null);
    const [uploading, setUploading] = useState(false);
    const [transferred, setTransferred] = useState(0);

    // useEffect(() => {
    //     checkForCameraRollPermission()
    // }, []);

    // const  checkForCameraRollPermission=async()=>{
    //     const { status } = await ImagePicker.getMediaLibraryPermissionsAsync();
    //     if (status !== 'granted') {
    //       alert("Please grant camera roll permissions inside your system's settings");
    //     } else {
    //       console.log('Media Permissions are granted')
    //     }
    // }

    const selectImage = async () => {
        let result = await ImagePicker.launchImageLibraryAsync({
            mediaTypes: ImagePicker.MediaTypeOptions.Images,
            allowsEditing: true,
            aspect: [4, 3],
            quality: 1,
        });

        console.log(result);

        if (!result.canceled) {
            console.log(result.assets[0].uri);
            setImage(result.assets[0].uri);
            uploadImage();
        }
    };
    
    const uploadImage = async () => {
        const filename = image.substring(image.lastIndexOf('/') + 1);
        const uploadUri = Platform.OS === 'ios' ? image.replace('file://', '') : image;

        setUploading(true);
        setTransferred(0);

        const task = storage()
          .ref(filename)
          .putFile(uploadUri);

        // set progress state
        task.on('state_changed', snapshot => {
            setTransferred(
                Math.round(snapshot.bytesTransferred / snapshot.totalBytes) * 10000
            );
        });

        try {
          await task;
        } catch (e) {
          console.error(e);
        }
        setUploading(false);
        Alert.alert(
          'Photo uploaded!',
          'Your photo has been uploaded to Firebase Cloud Storage!'
        );
        setImage(null);
    };

    return (
        <View style={styles.container}>
            { image && <Image source={{ uri: image.uri }} style={{ width: 100, height: 100 }} /> }
            <View style={styles.uploadButtonContainer}>
                <TouchableOpacity 
                    // onPress={selectImage} 
                    style={styles.uploadButton} >
                    <Text>{image ? 'Edit' : 'Not Supported'}</Text>
                    <Ionicons name="camera" size={20} color="darkgreen" />
                </TouchableOpacity>
            </View>
        </View>
    );
}

const styles = StyleSheet.create({
    container:{
        elevation:2,
        height:100,
        width:100,
        backgroundColor:'#efefef',
        position:'relative',
        borderRadius:999,
        overflow:'hidden',
    },
    uploadButtonContainer:{
        opacity:0.7,
        position:'absolute',
        right:0,
        bottom:0,
        backgroundColor:'lightgrey',
        width:'100%',
        height:'25%',
    },
    uploadButton:{
        display:'flex',
        alignItems:"center",
        justifyContent:'center'
    }
})