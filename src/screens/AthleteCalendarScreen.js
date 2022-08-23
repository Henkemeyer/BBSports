import React from 'react';
import { StatusBar, StyleSheet, Text, TouchableOpacity, View } from 'react-native';
import { Agenda } from 'react-native-calendars';

const timeToString = (time) => {
    const date = new Date(time);
    return date.toISOString().split('T')[0];
}

const AthleteCalendarScreen = () => {
    const [items, setItems] = React.useState({});
    const workout = {key: 'workout', color: 'green'};

    const loadItems = (day) => {

        setTimeout(() => {
            for (let i = -15; i < 85; i++) {
                const time = day.timestamp + i * 24 * 60 * 60 * 1000;
                const strTime = timeToString(time);

                if (!items[strTime]) {
                    items[strTime] = [];

                    items[strTime].push({ name: 'Item for ' + strTime, day: strTime, });
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
                markedDates={{
                    '2022-08-23': {dots: [workout]},
                    '2022-08-26': {dots: [workout]}
                  }}
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