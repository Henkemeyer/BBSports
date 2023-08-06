import React, { useContext, useEffect, useState } from 'react';
import { StatusBar, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import { Agenda, DateData, AgendaEntry, AgendaSchedule } from 'react-native-calendars';
import { UserContext } from '../../store/context/user-context';
import { fetchTeamCalendar } from '../../util/http';
import { subDays } from 'date-fns';
import { Ionicons } from '@expo/vector-icons';

const timeToString = (time) => {
    const date = new Date(time);
    return date.toISOString().split('T')[0];
}

const CoachCalendarScreen = ({ navigation }) => {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [items, setItems] = useState({});   // populates everyday
    const [events, setEvents] = useState({}); // card data
    const [marked, setMarked] = useState({}); // makes calendar dates
    const [minDate, setMinDate] = useState(new Date(new Date().valueOf() - 86400000));

    const workout = {key: 'workout', color: 'green'}; // Cardio, lifting, scrimmage?
    const competition = {key: 'competition', color: 'red'};  // Meet, game
    const activity = {key: 'activity', color: 'blue'};   // Pictures, miscellaneous

    // useEffect(() => {
    //     async function getTeamEvents() {
    //         const dbEvents = await fetchTeamCalendar(userCtx.teamId, token);
    //         const eventsObj = {};
    //         const markedObj = {};

    //         for (const key in dbEvents.data) {
    //             var time = '';
    //             const eventType = dbEvents.data[key].type;

    //             if(dbEvents.data[key].startTime) {
    //                 time = dbEvents.data[key].startTime;
    //                 if(dbEvents.data[key].endTime) {
    //                     time = time +" - "+ dbEvents.data[key].endTime;
    //                 }
    //             }
    //             else {
    //                 time = 'On Own';
    //             }
    //             const eventDate = dbEvents.data[key].date;
    //             const eventArr = {
    //                 id: key,
    //                 day: dbEvents.data[key].date,
    //                 teamName: dbEvents.data[key].teamName,
    //                 location: dbEvents.data[key].location,
    //                 time: time,
    //                 type: dbEvents.data[key].type,
    //             };

    //             let setDot = {};
    //             if(eventType==='Cardio' || eventType==='Lifting' || eventType==='Scrimmage' || eventType==='Practice') {
    //                 setDot = workout; 
    //             }
    //             else if(eventType==='Meet' || eventType==='Game' || eventType==='Match') {
    //                 setDot = competition;
    //             }
    //             else{
    //                 setDot = activity;
    //             }

    //             if(eventsObj[eventDate]){
    //                 eventsObj[eventDate] = [...eventsObj[eventDate], eventArr];
    //                 markedObj[eventDate]['dots'] = [...markedObj[eventDate]['dots'], setDot];
    //             }
    //             else {
    //                 eventsObj[eventDate] = eventArr;
    //                 markedObj[eventDate] = {dots: [setDot]};
    //             }
    //         }
    //         setEvents(eventsObj);
    //         setMarked(markedObj);
    //     }
    
    //     getTeamEvents();
    // }, []);

    // const loadItems = (day) => {

    //     setTimeout(() => {
    //         for (let i = -15; i < 50; i++) {
    //             const time = day.timestamp + i * 24 * 60 * 60 * 1000;
    //             const strTime = timeToString(time);

    //             items[strTime] = [];

    //             if (events[strTime]) {
    //                 items[strTime].push(events[strTime]);
    //             }

    //             items[strTime].push({
    //                 text: 'Add Event',
    //                 day: strTime,
    //                 placeholder: true
    //             });
    //         }
    //         const newItems = {};
    //         Object.keys(items).forEach(key => {
    //             newItems[key] = items[key];
    //         });

    //         setItems(newItems);
    //     }, 1000);
    // }

    const renderItem = (item) => {
        if(item.placeholder) {
            return (
                <TouchableOpacity style={styles.item} onPress={() => navigation.navigate('AddEvent', {day: item.day})}>
                    <View style={styles.viewRow}>
                        <Ionicons name="add-circle-outline" size={24} color="darkgreen"/>
                        <Text style={styles.itemText}>{item.text}</Text>
                    </View>
                </TouchableOpacity>
            );
        } else {
            return (
                <TouchableOpacity style={styles.item} onPress={() => navigation.navigate('EditEvent', {event: item})}>
                    <View>
                        <Text style={styles.itemText}>Team: {item.teamName}</Text>
                        <Text style={styles.itemText}>Loc: {item.location}</Text>
                        <Text style={styles.itemText}>Time: {item.time}</Text>
                    </View>
                </TouchableOpacity>
            );
        }
    }

    return (
        <View style={styles.container}>
            {/* <Agenda
                items={items}
                // loadItemsForMonth={loadItems}
                loadItemsForMonth={month => { console.log('trigger items loading'); }}
                markingType={'multi-dot'}
                markedDates={marked}
                selected={subDays(new Date(), 5)}
                todayTextColor= 'darkgreen'
                refreshControl={null}
                hideKnob={false}
                showClosingKnob={true}
                refreshing={false}
                renderItem={renderItem}
                // renderEmptyDate={() => { return <View />; }}
                theme={{
                    agendaDayTextColor: 'darkgreen',
                    agendaDayNumColor: 'green',
                    agendaTodayColor: 'green',
                    agendaKnobColor: 'darkgreen',
                    dotColor: '#ffffff',
                    indicatorColor: '#ffffff',
                    todayTextColor: 'orange',
                    dayTextColor: 'green',
                }}
            /> */}
            <TouchableOpacity style={styles.item} onPress={() => navigation.navigate('AddEvent')}>
                <View style={styles.viewRow}>
                    <Ionicons name="add-circle-outline" size={24} color="darkgreen"/>
                    <Text style={styles.itemText}>New Event</Text>
                </View>
            </TouchableOpacity>
            <StatusBar />
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        flex: 1,
    },
    item: {
        flex: 1,
        borderRadius: 5,
        borderWidth: 1,
        borderColor: 'darkgreen',
        padding: 10,
        marginRight: 10,
        marginTop: 17
    },
    viewRow: {
        flexDirection: 'row',
        padding: 10,
        alignItems: 'center'
    },
    itemText: {
        fontSize: 19,
        color: 'darkgreen',
        marginLeft: 10
    }
});

export default CoachCalendarScreen;