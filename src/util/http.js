import axios from 'axios';

const DB_URL = 'https://bbsports-e9a76-default-rtdb.firebaseio.com/';

export function postEquipment(equipment) {
    axios.post(DB_URL + 'equipment.json',
    equipment
    );
}

export async function fetchEquipment() {
    const response = await axios.get(DB_URL + 'equipment.json');

    const equipment = [];

    for (const key in response.data) {
        const equipmentObj = {
            id: key,
            name: response.data[key].name,
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