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

export async function fetchCardio(cardio, token) {
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