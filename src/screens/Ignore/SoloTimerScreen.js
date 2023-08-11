import React, { useContext, useState} from 'react';
import { Button, StyleSheet, Text, View } from 'react-native';
import OurButton from '../../components/OurButton';
import { postEquipment, fetchEquipment, patchEquipment } from '../../util/http';
import { UserContext } from '../../store/context/user-context';
import { Ionicons } from '@expo/vector-icons';
import { differenceInMilliseconds, format } from 'date-fns';

const SoloTimerScreen = () => {
  const userCtx = useContext(UserContext);
  const token = userCtx.token;
  const [running, setRunning] = useState(false)
  const [stopwatch, setStopwatch] = useState('0:00:00.00')
  const [timer, setTimer] = useState(null);


  const onButtonStart = () => {
    function start() {
      const startTime = new Date() 
      let timer = setInterval(() => {
        var milleseconds = differenceInMilliseconds(new Date(), startTime)
        setStopwatch(format(new Date(milleseconds - 64800000), 'H:mm:ss.SS'))
      }, 0);
      setTimer(timer);
    }

    start()
    setRunning(!running)
  }

  const onButtonStop = () =>{
      clearInterval(timer);
      setRunning(!running);
  }

  const onButtonClear = () =>{
      setStopwatch('0:00:00.00');
  }

  return(
    <View style={styles.container}>
      <Text style={styles.counter}>{stopwatch}</Text>
      <OurButton
        buttonText="Start"
        buttonPressed={onButtonStart}
        style={styles.swButton}
      />
      <OurButton 
        buttonText="Stop"
        buttonPressed={onButtonStop}
        style={styles.swButton}
      />
      <OurButton 
        buttonText="Clear"
        buttonPressed={onButtonClear}
        style={styles.swButton}
      />
    </View>
  );
}

const styles = StyleSheet.create({
    container: {
      flex: 1,
      alignItems: 'center',
      backgroundColor: 'linen',
      marginVertical: 25
    },
    counter: {
      fontSize: 60,
      textAlign: 'center',
      borderWidth: 1,
      borderRadius: 8,
      borderColor: 'black',
      backgroundColor: '#FFFFFF',
      margin: 20,
      paddingHorizontal: 7
    },
    miniCounter: {
        fontSize:20,
        position: 'relative',
        top: -32,
        right: -50
    },
    swButton: {
      width: '25%',
    }
});


export default SoloTimerScreen;