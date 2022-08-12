import axios from 'axios';

const DB_URL = 'https://bbsports-e9a76-default-rtdb.firebaseio.com/';
// ?auth=token

export function postUser(user, token) {
    axios.post(DB_URL + 'user.json?auth=' + token, user)
      .then(function (response) {
        console.log(response);
      })
      .catch(function (error) {
        console.log(error);
      });
}

export async function postEquipment(equipment, token) {
  await axios.post(DB_URL + 'equipment.json', equipment)
  .then(function (response) {
    const id = response.data.name;
    return id;
  })
  .catch(function (error) {
    console.log(error);
  });
}

export async function fetchEquipment(uid, token) {
  const response = await axios.get(DB_URL + 'equipment.json?orderBy="uid"&equalTo="'+uid+'"');

  const equipment = [];

  for (const key in response.data) {
      const equipmentObj = {
          id: key,
          name: response.data[key].equipName,
          distance: response.data[key].distance,
          // date: new Date(response.data[key].date)
      };
      equipment.push(equipmentObj);
  }

  return equipment;
}

export function deleteEquipment(equipId, token) {
  axios.delete(DB_URL + `equipment/${equipId}.json`)
  .then(function (response) {
    console.log('')
  })
  .catch(function (error) {
    console.log(error);
  });
}

/* Code to use in Screen
useEffect(() => {
    async function getEquipment() {
        const equipment = await fetchEquipment();
    }

    getEquipment();
}, []);
*/

export async function postCardio(cardio, token) {
  await axios.post(DB_URL + 'trainingLog.json', cardio)
  .then(function (response) {
    const id = response.data.name;
  })
  .catch(function (error) {
    console.log(error);
  });
}

export async function fetchCardio(uid, token) {
  const response = await axios.get(DB_URL + 'trainingLog.json?orderBy="uid"&equalTo="'+uid+'"');

  const trainingLog = [];

  for (const key in response.data) {
      const cardioObj = {
          id: key,
          date: new Date(response.data[key].date),
          distance: response.data[key].distance, // Convert this to units
          duration: response.data[key].duration, // Convert this to time
          notes: response.data[key].notes
      };
      trainingLog.push(cardioObj);
  }

  return trainingLog;
}

export async function postOrganization(org, coach, token) {
  const organizationId = '';
  await axios.post(DB_URL + 'organization.json', org)
  .then(function (response) {
    organizationId = response.data.name;
  })
  .catch(function (error) {
    console.log(error);
  });

  coach.organizationId = organizationId;

  await axios.post(DB_URL + 'coaches.json', coach)
  .then(function (response) {
    const placeholder = "Keep track of coach id?";
  })
  .catch(function (error) {
    console.log(error);
  });

  return organizationId;
}

export async function fetchOrganization(tbd, token) {
  const response = await axios.get(DB_URL + 'organization.json');

  const organizations = [];

  for (const key in response.data) {
      const orgObj = {
          id: key,
          name: response.data[key].name,
          desc: response.data[key].description,
          // Possible Editions:
          // Level: Child, high school, college, club, adult
          // Rating: 5 *'s... Rating and Review seperate file
          // Members: # of
          // Location: If they have meetups
          // Public, Private
          // Closed, Open, Fee?
      };
      organizations.push(orgObj);
  }

  return organizations;
}

export async function postCoach(coach, token) {
  await axios.post(DB_URL + 'coach.json', coach)
  .then(function (response) {
    const id = response.data.name;
  })
  .catch(function (error) {
    console.log(error);
  });
}

export async function fetchCoaches(tbd, token) {
  const response = await axios.get(DB_URL + 'coach.json'); // Probably need to filter by active, or organization

  const coaches = [];

  for (const key in response.data) {
      const coachObj = {
          id: key,
          firstName: response.data[key].firstName,
          lastName: response.data[key].lastName,
          nickName: response.data[key].nickName,
          organizationId: response.data[key].organizationId // 1 = Freelance Coach
          // Organizations?
      };
      coaches.push(coachObj);
  }

  return coaches;
}

export async function postAthlete(athlete, token) {
  await axios.post(DB_URL + 'athlete.json', athlete)
  .then(function (response) {
    const id = response.data.name;
    return id;
  })
  .catch(function (error) {
    console.log(error);
  });
}

export async function fetchAthlete(tbd, token) {
  const response = await axios.get(DB_URL + 'equipment.json?orderBy="uid"&equalTo="'+uid+'"');

  const athletes = [];

  for (const key in response.data) {
      const athleteObj = {
          id: key,
          name: response.data[key].equipName,
          distance: response.data[key].distance,
          // date: new Date(response.data[key].date)
      };
      athletes.push(athleteObj);
  }

  return athletes;
}

export async function fetchGroups(tbd, token) {
  const response = await axios.get(DB_URL + 'groups.json?orderBy="uid"&equalTo="'+uid+'"');

  const groups = [];

  for (const key in response.data) {
      const groupObj = {
          id: key,
          name: response.data[key].groupName,
          // athletes: [List of Athletes to push the workout too]
      };
      groups.push(groupObj);
  }

  return groups;
}