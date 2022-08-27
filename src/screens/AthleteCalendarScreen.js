import React, { useContext, useEffect, useState } from 'react';
import { StatusBar, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import { Agenda } from 'react-native-calendars';
import { UserContext } from '../store/context/user-context';
import { fetchEvents } from '../util/http';

const timeToString = (time) => {
    const date = new Date(time);
    return date.toISOString().split('T')[0];
}

const AthleteCalendarScreen = () => {
    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [items, setItems] = React.useState({});   // populates everyday
    const [events, setEvents] = React.useState({}); // card data
    const [marked, setMarked] = React.useState({}); // makes calendar dates
    // const events = {
    //     '2022-08-23': {dots: [workout]},
    //     '2022-08-23': {dots: [workout]}
    // };

    useEffect(() => {
        async function getEvents() {
            const dbEvents = await fetchEvents(userCtx.userId, token);
            const eventsObj = [];
            const markedObj = [];

            for (const key in dbEvents.data) {
                const time = '';
                if(dbEvents.data[key].startTime) {
                    time = dbEvents.data[key].startTime;
                    if(dbEvents.data[key].endTime) {
                        time = time +" - "+ dbEvents.data[key].endTime;
                    }
                }
                else {
                    time = 'On Own';
                }

                console.log(dbEvents.data[key]);
                const tmp = {dots: [workout]};
                const tmpDate = dbEvents.data[key].date;
                
                    // id: key,
                    // day: dbEvents.data[key].date,
                    // time: time,
                    // teamName: dbEvents.data[key].teamName,
                    // location: dbEvents.data[key].location,
                    // type: dbEvents.data[key].type
                // eventsObj.push(eventArr);

                // const temp = {
                //     dots: [dbEvents.data[key].type] 
                // };
                // console.log(temp);
                // console.log(eventsObj);
                // markedObj[dbEvents.data[key].date] = [];
                markedObj[tmpDate] = [1];
                markedObj[tmpDate].push(tmp);
            }
            console.log(markedObj);
            setEvents(eventsObj);
            setMarked(markedObj);
        }
    
        getEvents();
    }, [userCtx.getUserId]);


    const workout = {key: 'workout', color: 'green'}; // Cardio, lifting, scrimmage?
    const competition = {key: 'workout', color: 'green'};  // Meet, game
    const activity = {key: 'workout', color: 'green'};   // Pictures, miscellaneous

    const loadItems = (day) => {

        setTimeout(() => {
            for (let i = -15; i < 85; i++) {
                const time = day.timestamp + i * 24 * 60 * 60 * 1000;
                const strTime = timeToString(time);

                if (!events[strTime]) {
                    items[strTime] = [];

                    items[strTime].push({ name: 'Nothing Scheduled yet for ' + strTime, day: strTime, });
                }
            }
            const newItems = {};
            Object.keys(items).forEach(key => {
                newItems[key] = items[key];
            });
            setItems(newItems);
        }, 1000);
    }

    const renderItem = (item) => {
        return (
            <TouchableOpacity style={styles.item}>
                <View>
                    <Text>{item.name}</Text>
                </View>
            </TouchableOpacity>
        );
    }

    return (
        <View style={styles.container}>
            <Agenda
                items={items}
                loadItemsForMonth={loadItems}
                markingType={'multi-dot'}
                markedDates={marked}
                selected={new Date()}
                todayTextColor= 'darkgreen'
                refreshControl={null}
                hideKnob={false}
                showClosingKnob={true}
                refreshing={false}
                renderItem={renderItem}
                renderEmptyDate={() => { return <View />; }}
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
            />
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
        padding: 10,
        marginRight: 10,
        marginTop: 17
    },
});

export default AthleteCalendarScreen;