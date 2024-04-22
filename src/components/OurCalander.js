import React from 'react';
import { View, Text, StyleSheet } from 'react-native';
import {Calendar, CalendarList, Agenda} from 'react-native-calendars';

export default function OurCalander(){
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
                // The list of items that have to be displayed in agenda. If you want to render item as empty date
                // the value of date key has to be an empty array []. If there exists no value for date key it is
                // considered that the date in question is not yet loaded

                // Callback that gets called when items for a certain month should be loaded (month became visible)
                loadItemsForMonth={month => {
                    console.log('trigger items loading');
                }}
                // Callback that gets called on day press
                onDayPress={day => {
                    console.log('day pressed');
                }}
                // Callback that gets called when day changes while scrolling agenda list
                onDayChange={day => {
                    console.log('day changed');
                }}
                // Initially selected day
                selected={'2022-08-22'}
                // Max amount of months allowed to scroll to the future. Default = 50
                futureScrollRange={12}
                // Specify how each item should be rendered in agenda
                renderItem={(item, firstItemInDay) => {
                    return (
                        <View>
                            <Text>{item.name}</Text>
                        </View>
                    );
                }}
                // Specify how each date should be rendered. day can be undefined if the item is not first in that day
                // renderDay={(day, item) => {
                //     return (
                //         <View>
                //             <Text>hello</Text>
                //         </View>
                //     );
                // }}
                // Specify how empty date content with no items should be rendered
                renderEmptyDate={() => { return <View />; }}
                // Specify how agenda knob should look like
                // renderKnob={() => {
                //     return <View style={styles.knob}/>;
                // }}
                // Specify what should be rendered instead of ActivityIndicator
                renderEmptyData={() => {
                    return <View />;
                }}
                // Specify your item comparison function for increased performance
                rowHasChanged={(r1, r2) => {
                    return r1.text !== r2.text;
                }}
                // Hide knob button. Default = false
                hideKnob={false}
                // When `true` and `hideKnob` prop is `false`, the knob will always be visible and the user will be able to drag the knob up and close the calendar. Default = false
                showClosingKnob={true}
                // If provided, a standard RefreshControl will be added for "Pull to Refresh" functionality. Make sure to also set the refreshing prop correctly
                onRefresh={() => console.log('refreshing...')}
                // Set this true while waiting for new data from a refresh
                refreshing={false}
                // Add a custom RefreshControl component, used to provide pull-to-refresh functionality for the ScrollView
                refreshControl={null}
                // Agenda theme
                theme={{
                    // ...calendarTheme,
                    agendaDayTextColor: 'darkgreen',
                    agendaDayNumColor: 'green',
                    agendaTodayColor: 'green',
                    agendaKnobColor: 'darkgreen'
                }}
                // Agenda container style
                style={{color: 'red'}}
            />
        </View>
    );
}

const styles = StyleSheet.create({
    dayContainer: {
        width: '100%',
        borderWidth: 1,
        borderColor: 'gray',
        backgroundColor: '#ffffff',
        borderRadius: 10,
        shadowColor: 'black',
        shadowOpacity: 0.33,
        shadowRadius: 8,
        shadowOffset: { width: 0, height: 2 },
        elevation: 15
    },
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