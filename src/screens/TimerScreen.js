import React, { Component } from 'react';
import { AppRegistry, StyleSheet, Text, View, TouchableHighlight } from 'react-native';
import { Stopwatch } from 'react-native-stopwatch-timer';
 
class TimerScreen extends Component {
  constructor(props) {
    super(props);
    this.state = {
      stopwatchStart: false,
      stopwatchReset: false,
    };
    this.toggleStopwatch = this.toggleStopwatch.bind(this);
    this.resetStopwatch = this.resetStopwatch.bind(this);
  }
 
  toggleStopwatch() {
    this.setState({stopwatchStart: !this.state.stopwatchStart, stopwatchReset: false});
  }
 
  resetStopwatch() {
    this.setState({stopwatchStart: false, stopwatchReset: true});
  }
  
//   getFormattedTime(time) {
//       this.currentTime = time;
//   };
 
  render() {
    return (
        <View >
            <View style={styles.timerViewStyle} >
                <Stopwatch laps msecs start={this.state.stopwatchStart}
                reset={this.state.stopwatchReset}
                options={options}
                getTime={this.getFormattedTime} />
            </View>
            <View style={styles.buttonViewStyle}>
                <TouchableHighlight style={styles.buttonStyle} onPress={this.resetStopwatch}>
                    <Text style={styles.textStyle}>Reset</Text>
                </TouchableHighlight>
                <TouchableHighlight style={styles.buttonStyle} onPress={this.toggleStopwatch}>
                    <Text style={styles.textStyle}>{!this.state.stopwatchStart ? "Start" : "Lap"}</Text>
                </TouchableHighlight>
            </View>
        </View>
    );
  }
}
 
const options = {
  container: {
    backgroundColor: '#FFF',
    padding: 5,
    borderRadius: 10,
    width: 200,
  },
  text: {
    fontSize: 30,
    color: '#000',
    marginLeft: 7,
  }
};

const styles = StyleSheet.create({
    timerViewStyle: {
        alignItems: 'center',
        paddingVertical: 20
    },
    buttonStyle: {
        width: '33%',
        borderWidth: 1,
        borderColor: 'black',
        borderRadius: 10,
        backgroundColor: 'green'
    },
    buttonViewStyle: {
        flexDirection: 'row',
        justifyContent: 'space-around'
    },
    textStyle: {
        fontSize: 30,
        textAlign: 'center',
        textAlignVertical: 'center'
    }
});
 
export default TimerScreen;
// AppRegistry.registerComponent('TestApp', () => TestApp);