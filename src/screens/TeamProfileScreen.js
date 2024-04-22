import React, { useContext, useEffect, useState } from 'react';
import { Alert, Button, Image, StyleSheet, Text, View } from 'react-native';
import { UserContext } from '../store/context/user-context';
import { fetchTeam, fetchAthletesByTeam, fetchCoachesByTeam } from '../util/http';
import UploadProfilePicture from '../components/UploadProfilePicture';

const TeamProfileScreen = ({ navigation }) => {
  const userCtx = useContext(UserContext);
  const [imageUri, setImageUri] = useState(null);
  const [teamInfo, setTeamInfo] = useState({});
  const [teamCoaches, setTeamCoaches] = useState([]);
  const [teamAthletes, setTeamAthletes] = useState([]);

  useEffect(() => {
    async function getEvents() {
        try {
          const dbTeam = await fetchTeam(userCtx.teamId, userCtx.token);
          setTeamInfo(dbTeam.data);
        } catch (error) {
            Alert.alert('Database Error!', 'Failed to fetch team. '+error)
        }

        try {
          const dbCoaches = await fetchCoachesByTeam(userCtx.organizationId, userCtx.teamId, userCtx.token);
          const coaches = Object.entries(dbCoaches.data).map((item, index) => (
            <View key={'vc'+index} style={styles.coachView}>
                <Text key={'tc'+index}>
                  {item[1].fullName} 
                  {item[1].title}{'\n'}
                  {item[1].phone}
                  {item[1].email}
                </Text>
            </View>
          ));
          setTeamCoaches(coaches);
        } catch (error) {
            Alert.alert('Database Error!', 'Failed to fetch coaches. '+error)
        }

        try {
          const dbAthletes = await fetchAthletesByTeam(userCtx.organizationId, userCtx.teamId, userCtx.token);
          const athletes = Object.entries(dbAthletes.data).map((item, index) => (
            <View key={'va'+index} style={styles.athleteView}>
                <Text key={'ta'+index}>
                  {item[1].fullName} 
                  {item[1].year}
                  {item[1].status === 'C' ? "Captain" : null}
                </Text>
            </View>
          ));
          setTeamAthletes(athletes);
        } catch (error) {
            Alert.alert('Database Error!', 'Failed to fetch athletes. '+error)
        }
    }

    getEvents();
}, []);

  return (
    <View style={styles.container}>
      <View style={styles.image}>
        <UploadProfilePicture />
      </View>
      <Text>{teamInfo.organizationName}</Text>
      <Text>{userCtx.teamName}</Text>
      <Text>Sport: {teamInfo.sport}</Text>
      <Text>Level: {teamInfo.level}</Text>
      <Text>Sub Level: {teamInfo.subLevel}</Text>
      <Text>Sex: {teamInfo.sex}</Text>
      <Text>Location: {teamInfo.location}</Text>
      <Text>Website: {teamInfo.website}</Text>
      <Text>Coaches: </Text>
      {teamCoaches}
      <Text>Athletes: </Text>
      {teamAthletes}
      <Text>Schedule: </Text>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 20
  },
  image: {
    width: 100,
    height: 100,
    resizeMode: 'contain'
  },
  coachView: {
      width: '90%',
      alignItems: 'flex-start',
      borderWidth: 3,
      borderColor: 'darkgreen',
      backgroundColor: 'white',
      borderRadius: 10,
      margin: 10,
      padding: 10
  },
  athleteView: {
      width: '90%',
      alignItems: 'flex-start',
      borderWidth: 1,
      borderColor: 'darkgreen',
      backgroundColor: 'white',
      borderRadius: 10,
      marginHorizontal: 10,
      padding: 10
  }
});

export default TeamProfileScreen;