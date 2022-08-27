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

export async function fetchUser(uid, token) {
  return await axios.get(DB_URL + 'user.json?orderBy="uid"&equalTo="'+uid+'"&print=pretty');
}

export async function postEquipment(equipment, token) {
  return await axios.post(DB_URL + 'equipment.json', equipment);
}

export async function fetchEquipment(uid, token) {
  return await axios.get(DB_URL + 'equipment.json?orderBy="uid"&equalTo="'+uid+'"');
}

export async function patchEquipment(equipId, data, token) {
  await axios.patch(DB_URL + 'equipment/' + equipId +'.json', data);
}

/* Code to use in Screen
useEffect(() => {
    async function getEquipment() {
        const equipment = await fetchEquipment();
    }

    getEquipment();
}, []);
*/

export async function postEvent(event, token) {
  await axios.post(DB_URL + 'event.json', event);
}

export async function fetchEvents(uid, token) {
  return await axios.get(DB_URL + 'event.json?orderBy="uid"&equalTo="'+uid+'"');
}

export async function postCardioLog(cardio, token) {
  await axios.post(DB_URL + 'cardio.json', cardio);
}

export async function postOrganization(org, token) {
  return await axios.post(DB_URL + 'organization.json', org);
}

export async function fetchOrganizations(tbd, token) {
  const response = await axios.get(DB_URL + 'organization.json');

  const organizations = [];

  for (const key in response.data) {
      const orgObj = {
          id: key,
          name: response.data[key].name,
          description: response.data[key].description,
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

export async function postTeam(team, token) {
  await axios.post(DB_URL + 'team.json', team)
  .then(function (response) {
    console.log('Team ID: ' + response.data.name)
  })
  .catch(function (error) {
    console.log(error);
  });
}

export async function fetchOrgTeams(orgId, token) {
  const response = await axios.get(DB_URL + 'team.json?orderBy="organizationId"&equalTo="'+orgId+'"');

  const teams = [];

  for (const key in response.data) {
      const teamObj = {
          id: key,
          name: response.data[key].name,
          description: response.data[key].description,
          organizationId: response.data[key].organizationId
      };
      teams.push(teamObj);
  }

  return teams;
}

export async function fetchCoachTeams(uid, token) {
  const response = await axios.get(DB_URL + 'coach.json?orderBy="uid"&equalTo="'+uid+'"');

  const teams = [];

  for (const key in response.data) {
      const teamObj = {
          id: response.data[key].teamId,
          name: response.data[key].teamName,
          status: response.data[key].status,
          title: response.data[key].title
      };
      teams.push(teamObj);
  }

  return teams;
}

export async function postCoach(coach, token) {
  await axios.post(DB_URL + 'coach.json', coach)
  .then(function (response) {
    console.log('Coach ID: ' + response.data.name)
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
          title: response.data[key].title,
          fullName: response.data[key].fullName,
          organizationId: response.data[key].organizationId, // 1 = Freelance Coach
          userId: response.data[key].uid,
          status: response.data[key].status
          // Organizations?
      };
      coaches.push(coachObj);
  }

  return coaches;
}

export async function postAthlete(athlete, token) {
  return await axios.post(DB_URL + 'athlete.json', athlete);
}

export async function patchAthlete(athleteId, data, token) {
  await axios.patch(DB_URL + 'athlete/' + athleteId +'.json', data);
}

export async function fetchRoster(teamId, token) {
  return await axios.get(DB_URL + 'athlete.json?orderBy="teamId"&equalTo="'+teamId+'"');
}

export async function fetchAthleteGroup(tbd, token) {
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

export async function fetchGroups(teamId, token) {
  const response = await axios.get(DB_URL + 'groups.json?orderBy="teamId"&equalTo="'+teamId+'"');

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