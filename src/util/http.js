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
    return response;
  })
  .catch(function (error) {
    console.log(error);
  });
}

export async function fetchEquipment(uid, token) {
  const response = await axios.get(DB_URL + 'equipment.json?orderBy="uid"&equalTo="'+uid+'"');
//?orderBy="uid"&equalTo=' + uid
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

/* Code to use in Screen
useEffect(() => {
    async function getEquipment() {
        const equipment = await fetchEquipment();
    }

    getEquipment();
}, []);
*/