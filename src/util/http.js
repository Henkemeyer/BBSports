import axios from 'axios';

const DB_URL = 'https://bbsports-e9a76-default-rtdb.firebaseio.com/';
// ?auth=token

// Login and Profile Screens
export function putUser(user, authData) {
    axios.put(DB_URL + 'user/'+authData.localId+'.json?auth=' + authData.idToken, user);
}

export async function fetchUser(uid, token) {
  return await axios.get(DB_URL + 'user/'+uid+'.json?auth='+ token);
}

export async function patchUser(uid, token, userData) {
  await axios.patch(DB_URL + 'user/'+uid+'.json?auth='+ token, userData);
}

// Create, Manage, Find Organizations
export async function postOrganization(orgData, token) {
  return await axios.post(DB_URL + 'organization.json?auth='+ token, orgData);
}

export async function putAdmin(adminData, orgId, token) {
  return await axios.put(DB_URL + 'member/'+orgId+'.json?auth='+ token, adminData);
}

export async function fetchOrganization(orgId, token) {
  return await axios.get(DB_URL + 'organization/'+orgId+'.json?auth='+ token);
}

export async function fetchOrganizationsByAdmin(uid, token) {
 return await axios.get(DB_URL + 'admin/'+uid+'.json?auth='+ token);
}

export async function fetchAdminsByOrganization(orgId, token) {
  return await axios.get(DB_URL + 'member/'+orgId+'/admin.json?auth='+ token);
 }

 // Equipment and Training Log Screens
export async function postEquipment(uid, equipment, token) {
  return await axios.post(DB_URL + 'equipment/'+uid+'.json?auth='+ token, equipment);
}

export async function fetchEquipment(uid, token) {
  return await axios.get(DB_URL + 'equipment/'+uid+'.json?orderBy="status"&equalTo="A"');
}

export async function fetchAllEquipment(uid, token) {
  return await axios.get(DB_URL + 'equipment/'+uid+'.json');
}

export async function patchEquipment(equipId, data, token) {
  await axios.patch(DB_URL + 'equipment/' + equipId +'.json?auth='+ token, data);
}

export async function postCardioLog(cardio, token) {
  await axios.post(DB_URL + 'cardioLog.json', cardio);
}

/* Code to use in Screen
useEffect(() => {
    async function getEquipment() {
        const equipment = await fetchEquipment();
    }

    getEquipment();
}, []);
*/

export async function postCalendar(calendar, token) {
  return await axios.post(DB_URL + 'calendar.json', calendar);
}

export async function patchCalendar(calendarId, calendar, token) {
  await axios.patch(DB_URL + 'calendar/'+calendarId+'.json', calendar);
}

export async function fetchUserCalendar(uid, token) {
  return await axios.get(DB_URL + 'calendar.json?orderBy="uid"&equalTo="'+uid+'"');
}

export async function fetchTeamCalendar(teamId, token) {
  return await axios.get(DB_URL + 'calendar.json?orderBy="teamId"&equalTo="'+teamId+'"');
}


export async function fetchCardioLog(uid, token) {
  return await axios.get(DB_URL + 'cardioLog.json?orderBy="uid"&equalTo="'+uid+'"&limitToLast=100');
}

export async function postTeam(teamData, token) {
  return await axios.post(DB_URL + 'team.json?auth='+ token, teamData);
}

export async function fetchTeam(teamId, token) {
  return await axios.get(DB_URL + 'team/'+teamId+'.json');
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

export async function fetchCoach(uid, token) {
  const response = await axios.get(DB_URL + 'coach.json?orderBy="uid"&equalTo="'+uid+'"');

  const coach = [];

  for (const key in response.data) {
      const coachObj = {
        id: key,
        userId: response.data[key].uid,
        organizationId: response.data[key].organizationId,
        teamId: response.data[key].teamId,
        title: response.data[key].title,
        fullName: response.data[key].fullName,
        status: response.data[key].status
      };
      coach.push(coachObj);
  }

  return coach;
}

export async function fetchCoachesByTeam(teamId, token) {
  const response = await axios.get(DB_URL + 'coach.json?orderBy="teamId"&equalTo="'+teamId+'"');

  const coaches = [];

  for (const key in response.data) {
      const coachObj = {
        id: key,
        userId: response.data[key].uid,
        organizationId: response.data[key].organizationId, // 1 = Freelance Coach
        teamId: response.data[key].teamId, // 1 = Freelance Coach
        title: response.data[key].title,
        fullName: response.data[key].fullName,
        status: response.data[key].status
      };
      coaches.push(coachObj);
  }

  return coaches;
}

export async function fetchCoachByOrg(orgId, token) {
  const response = await axios.get(DB_URL + 'coach.json?orderBy="orgId"&equalTo="'+orgId+'"');

  const coaches = [];

  for (const key in response.data) {
      const coachObj = {
        id: key,
        userId: response.data[key].uid,
        organizationId: response.data[key].organizationId, // 1 = Freelance Coach
        teamId: response.data[key].teamId, // 1 = Freelance Coach
        title: response.data[key].title,
        fullName: response.data[key].fullName,
        status: response.data[key].status
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

export async function postEvent(event, token) {
  return await axios.post(DB_URL + 'event.json', event);
}

// export async function patchEvent(athleteId, data, token) {
//   await axios.patch(DB_URL + 'athlete/' + athleteId +'.json', data);
// }