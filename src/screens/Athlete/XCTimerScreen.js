import React, { useContext, useEffect, useState} from 'react';
import { Button, ScrollView, StyleSheet, Text, TextInput, TouchableOpacity, View } from 'react-native';
import OurButton from '../../components/OurButton';
import { postEquipment, fetchEquipment, patchEquipment, postEvent } from '../../util/http';
import { UserContext } from '../../store/context/user-context';
import { Table, TableWrapper, Row, Cell } from 'react-native-table-component';
import { Ionicons } from '@expo/vector-icons';
import { differenceInMilliseconds, format } from 'date-fns';

const XCTimerScreen = ({ navigation, route}) => {
    const { meet, event, numSplits, athletes } = route.params

    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [running, setRunning] = useState(false)
    const [stopwatch, setStopwatch] = useState('0:00:00.00')
    const [timer, setTimer] = useState(null);
    const [tableForm, setTableForm] = useState([]); // Table of UX elements
    const [tableData, setTableData] = useState([]); // Table of actual values
    const [header, setHeader] = useState([]);

    useEffect(() => {
        function initializeValues() {
            let tempTableData = Array(athletes.length+1).fill(0).map(row => new Array(parseInt(numSplits)+1).fill(''))
            tempTableData[0][0] = 'Name'

            for(let x=1; x<=numSplits; x++) {
                tempTableData[0][x] = (Math.ceil((event.distance / numSplits) * x)).toString()
            }

            athletes.map((data, index) => (
                tempTableData[index+1][0] = data.name
            ))
            
            setTableData(tempTableData)

            let tempHeader = Array(2).fill(0).map(row => new Array(parseInt(numSplits)+1).fill(150))
            tempHeader[0][0] = <Text>Name</Text>

            let tempTable = Array(athletes.length).fill(0).map(row => new Array(parseInt(numSplits)+1).fill(''))
            
            for(let x=1; x<=numSplits; x++) {
                tempHeader[0][x] = <TextInput
                    maxLength={5}
                    keyboardType='numeric'
                    defaultValue={tempTableData[0][x]}
                    onChangeText={text => {
                        let tableDataCopy = tableData
                        tableDataCopy[0][x] = text

                        setTableData(tableDataCopy)
                    }}
                    style={styles.cellText}/>
            }

            athletes.map((data, index) => (
                tempTable[index][0] = data.name
            ))
            
            setHeader(tempHeader)
            setTableForm(tempTable)
        }

        initializeValues();
    }, [route.params]);

    function setTableCell(row, value) {
        const next = tableData[row+1].findIndex((data) => data === '')
        let tableDataCopy = tableData
        let tableFormCopy = tableForm
        if(next > 0) {
            tableDataCopy[row+1][next] = value
            tableFormCopy[row][next] = value
        }
        else {
            const numColumns = tableData[0].length
            const numRows = tableData.length

            for(let y=0; y<numRows; y++) {
                if(y === 0) {
                    let headerCopy = header
                    const nextSplit = parseInt(tableDataCopy[0][numColumns-1])+200
                    tableDataCopy[0].push(nextSplit)

                    headerCopy[0].push(<TextInput
                        maxLength={5}
                        keyboardType='numeric'
                        defaultValue={nextSplit}
                        onChangeText={text => {
                            let tableDataCopy = tableData
                            tableDataCopy[0][numColumns] = text

                            setTableData(tableDataCopy)
                        }}
                        style={styles.cellText}/>)

                    headerCopy[1].push(150)
                    console.log(headerCopy)
                    setHeader(headerCopy)
                }
                else if(y === row+1) {
                    tableDataCopy[y].push(value)
                    tableFormCopy[y-1].push(value)
                }
                else {
                    tableDataCopy[y].push('')
                    tableFormCopy[y-1].push('')
                }
            }
        }

        setTableData(tableDataCopy)
        setTableForm(tableFormCopy)
    }

    const onButtonStart = () => {
        function start() {
            const startTime = new Date() 
            let timer = setInterval(() => {
                var milleseconds = differenceInMilliseconds(new Date(), startTime)
                setStopwatch(format(new Date(milleseconds - 64800000), 'H:mm:ss.SS'))
            }, 100);
        setTimer(timer);
        }

        start()
        setRunning(true)
    }

    const onButtonStop = () =>{
        clearInterval(timer);
        setRunning(false);
    }

    const onButtonClear = () =>{
        setStopwatch('0:00:00.00');
        clearInterval(timer);
        setRunning(false);
    }

    const submitSplits = () => {
        for(let x=1;x<tableData.length;x++){
            let splits = []
            for(let y=1;y<tableData[x].length;y++){
                const truple = [tableData[0][y],tableData[x][y]]
                splits.push(truple)
            }

            try {
                const eventData = {
                    calendarId:meet.id,
                    calendarName:meet.name,
                    eventName:event.name,
                    athleteId:athletes[x-1].uid,
                    athleteName:athletes[x-1].name,
                    stats: splits
    
                }
                postEvent(eventData, token)
            } catch (error) {
                Alert.alert('Split Creation Failed!', 'Failed to post splits. Sorry for the inconvenience') 
            }
        }
        navigation.goBack();
    }

    return(
        <ScrollView>
        <View style={styles.container}>
            <Text style={styles.header}>{meet.name}</Text>
            <Text style={styles.header}>{event.name}</Text>
            <Text style={styles.counter}>{stopwatch}</Text>
            <OurButton
                buttonText="Start"
                buttonPressed={onButtonStart}
                disabled={running}
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
            <View style={styles.athleteRow}>
                {athletes.map((athlete, index) => (
                    <TouchableOpacity
                        testID={athlete.id}
                        onPress={() => setTableCell(index, stopwatch)}
                        style={styles.athleteButton}>
                        <Text style={{fontWeight:'bold'}}>{athlete.name}</Text>
                    </TouchableOpacity>
                ))}
            </View>
            <ScrollView horizontal={true} style={{paddingVertical: 20}}>
                <View>
                    <Table borderStyle={{borderColor: 'black', borderRadius: 5}}>
                        <Row data={header[0]} widthArr={header[1]} style={styles.head}/>
                    </Table>
                    <ScrollView style={styles.dataWrapper}>
                        <Table borderStyle={{borderColor: 'black', borderRadius: 5}}>
                            { tableForm.map((dataRow, index) => (
                                <TableWrapper key={index} style={ index%2 ? styles.rowA : styles.rowB}>
                                    {dataRow.map((cellData, cellIndex) => (
                                        <Cell 
                                            key={index+','+cellIndex}
                                            data={cellData}
                                            style={{width: 150}}
                                        />
                                ))}
                                </TableWrapper>
                            ))}
                        </Table>
                    </ScrollView>
                </View>
            </ScrollView>
            <View style={{alignItems: 'center'}}>
                <OurButton
                    buttonText="Submit"
                    buttonPressed={submitSplits}
                />
            </View>
        </View>
        </ScrollView>
    );
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        alignItems: 'center',
        backgroundColor: '#F4F4F4',
        paddingVertical: 25
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
    header: {
        fontSize:20,
        color: 'darkgreen',
        marginBottom: 20
    },
    inputHeader: {
        fontSize: 15,
        color: 'gray',
        textAlignVertical: 'center'
    },
    inputContainer: {
        backgroundColor: 'white',
        borderBottomWidth: 1,
        borderColor: 'darkgreen',
        margin:10,
        padding:5,
        borderRadius:8,
        textAlign: 'center'
    },
    swButton: {
        width: '50%',
        marginVertical: 5
    },
    athleteRow: {
        flexDirection: 'row',
        flexWrap: 'wrap',
        margin: 12,
        backgroundColor: 'white',
        borderRadius: 8
    },
    athleteButton: {
        borderRadius: 100,
        borderWidth: 1,
        margin: 5,
        padding: 8,
        backgroundColor: 'lightgreen'
    },
    tableHeader: {
        width: '80%',
        fontSize: 18,
        fontWeight: 'bold',
        color: 'black',
        textAlign: 'center',
        borderColor: 'black'
    },
    head: { 
        height: 50, 
        backgroundColor: 'green',
        borderRadius: 5
    }, 
    cellText: { 
        textAlign: 'center', 
        fontWeight: '200' 
    },
    dataWrapper: { 
        marginTop: -1
    },
    rowA: { 
        flexDirection: 'row',
        height: 40, 
        backgroundColor: '#F7F8FA' 
    },
    rowB: { 
        flexDirection: 'row',
        height: 40, 
        backgroundColor: '#ffffff' 
    },
});


export default XCTimerScreen;