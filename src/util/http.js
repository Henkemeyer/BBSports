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
// Assign new Admin
export async function putAdmin(adminData, orgId, token) {
  return await axios.put(DB_URL + 'member/'+orgId+'.json?auth='+ token, adminData);
}
// Fetch Org Info
export async function fetchOrganization(orgId, token) {
  return await axios.get(DB_URL + 'organization/'+orgId+'.json?auth='+ token);
}
// Fetch all Orgs a user controls
export async function fetchOrganizationsByAdmin(uid, token) {
  return await axios.get(DB_URL + 'admin/'+uid+'.json?auth='+ token);
}
// Fetch all admins who control an Org
export async function fetchAdminsByOrganization(orgId, token) {
  return await axios.get(DB_URL + 'member/'+orgId+'/admin.json?auth='+ token);
}
// Create new Team
export async function postTeam(teamData, token) {
  return await axios.post(DB_URL + 'team.json?auth='+ token, teamData);
}

// Create, Manage, Find Teams
export async function fetchTeam(teamId, token) {
  return await axios.get(DB_URL + 'team/'+teamId+'.json?auth='+ token);
}

export async function fetchTeamsByAthlete(uid, token) {
  return await axios.get(DB_URL + 'athlete/'+uid+'.json?auth='+ token);
}

export async function fetchTeamsByCoach(uid, token) {
  return await axios.get(DB_URL + 'coach/'+uid+'.json?auth='+ token);
}

export async function fetchTeamsByOrganization(orgId, token) {
  return await axios.get(DB_URL + 'team.json?orderBy="organizationId"&equalTo="'+orgId+'"');
}

// Messaging System
// Create a new chat room
export async function postChatRoom(chatRoom, uid, token) {
  return await axios.post(DB_URL + 'chatRoom/'+uid+'.json?auth='+token, chatRoom);
}
// Fetch all chat rooms for user
export async function fetchChatRooms(uid, token) {
  return await axios.get(DB_URL + 'chatRooms/'+uid+'.json?auth='+token);
}
// Fetch last messages for chat room
export async function fetchMessages(chatRoom, token) { // TODO Limit this to last 50
  return await axios.get(DB_URL + 'messages/'+chatRoom+'.json?auth='+token);
}
// Post a new message
export async function postMessage(chatRoom, message, token) {
  return await axios.post(DB_URL + 'messages/'+chatRoom+'.json?auth='+token, message);
}

 // Equipment and Training Log Screens
export async function postEquipment(uid, equipment, token) {
  return await axios.post(DB_URL + 'equipment/'+uid+'.json?auth='+ token, equipment);
}
// Fetch all active equipment
export async function fetchEquipment(uid, token) {
  return await axios.get(DB_URL + 'equipment/'+uid+'.json?orderBy="status"&equalTo="A"');
}
// Fetch all equipment a user has entered
export async function fetchAllEquipment(uid, token) {
  return await axios.get(DB_URL + 'equipment/'+uid+'.json');
}
// Update equipment name, distance or status
export async function patchEquipment(equipId, data, token) {
  await axios.patch(DB_URL + 'equipment/' + equipId +'.json?auth='+ token, data);
}

// Calendar and Event screens
// New Practice, Activity, Competition
export async function postCalendarEvent(event, token) {
  return await axios.post(DB_URL + 'calendarEvent.json?auth='+ token, event);
}
// Add to everyones personal calendar
export async function putCalendar(calendar, token) {
  return await axios.put(DB_URL + 'calendar.json?auth='+ token, calendar);
}
// Update everyones personal calendar
export async function patchCalendarEvent(calendarEventId, calendarEvent, token) {
  await axios.patch(DB_URL + 'calendarEvent/'+calendarEventId+'.json?auth='+ token, calendarEvent);
}
// Update a practice, activity or competition
export async function patchCalendar(calendarId, calendar, token) {
  await axios.patch(DB_URL + 'calendar/'+uid+'/'+calendarId+'.json?auth='+ token, calendar);
}
// Cancel a practice, activity or competition
export async function cancelCalendarEvent(calendarEventId, token) {
  await axios.delete(DB_URL + 'calendarEvent/'+calendarEventId+'.json?auth='+ token);
}
// Remove the event from a personal calendar
export async function declineCalendarEvent(calendarId, token) {
  await axios.delete(DB_URL + 'calendar/'+uid+'/'+calendarId+'.json?auth='+ token);
}
// Fetch all events for a personal Agenda
export async function fetchUserCalendar(uid, token) { // TODO: add in performance filter
  return await axios.get(DB_URL + 'calendar/'+uid+'.json?auth='+ token);
}
// TODO Pull competitions for Team Profile Screen
export async function fetchTeamCompetitions(teamId, token) {
  return await axios.get(DB_URL + 'calendar.json?orderBy="teamId"&equalTo="'+teamId+'"');
}




export async function postCardioLog(cardio, token) {
  await axios.post(DB_URL + 'cardioLog.json?auth='+ token, cardio);
}

export async function fetchCardioLog(uid, token) {
  return await axios.get(DB_URL + 'cardioLog.json?orderBy="uid"&equalTo="'+uid+'"&limitToLast=100');
}




export async function postCoach(coach, token) {
  return await axios.post(DB_URL + 'coach.json?auth='+ token, coach);
}

export async function fetchCoach(uid, token) {
  return await axios.get(DB_URL + 'coach.json?orderBy="uid"&equalTo="'+uid+'"');
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
  return await axios.get(DB_URL + 'groups/'+teamId+'.json?auth='+ token);
}