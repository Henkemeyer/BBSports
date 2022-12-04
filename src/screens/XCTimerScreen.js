import React, { useContext, useEffect, useState} from 'react';
import { Button, ScrollView, StyleSheet, Text, TextInput, TouchableOpacity, View } from 'react-native';
import OurButton from '../components/OurButton';
import { postEquipment, fetchEquipment, patchEquipment } from '../util/http';
import { UserContext } from '../store/context/user-context';
import { Table, TableWrapper, Row, Cell } from 'react-native-table-component';
import { Ionicons } from '@expo/vector-icons';
import { differenceInMilliseconds, format } from 'date-fns';

const XCTimerScreen = ({ navigation, route}) => {
    const { meet, event, athletes } = route.params

    const userCtx = useContext(UserContext);
    const token = userCtx.token;
    const [numSplits, setNumSplits] = useState(1);
    const [running, setRunning] = useState(false)
    const [stopwatch, setStopwatch] = useState('0:00:00.00')
    const [timer, setTimer] = useState(null);
    const [tableForm, setTableForm] = useState([]); // Table of UX elements
    const [tableData, setTableData] = useState([]); // Table of actual values
    const [header, setHeader] = useState([]);
    const [headerValues, setHeaderValues] = useState([]);

    useEffect(() => {
        function initializeValues() {
            let tmpForm = []

            athletes.map((data, index) => (
                tmpForm[index] = [data.name]
            ))
            setTableForm(tmpForm)
            setHeader({
                tableHead: ['Name'],
                widthArr: [150],
            })
        }

        initializeValues();
    }, [route.params]);

    const generateTable = () => {
        if(numSplits === '' || numSplits === '0') {
            setNumSplits('1')
        }

        const tempTableData = [];
        const tempTableForm = [];
        const tmpHeader = {
            tableHead: ['Name'],
            widthArr: [150],
        }
        const tmpHeaderVal = ['Name']

        athletes.map((data, index) => (
            tempTableForm[index] = [data.name]
        ))
        athletes.map((data, index) => (
            tempTableData[index] = [data.id]
        ))

        for(let x=0; x<athletes.length; x++) {
            for(let y=1; y<=numSplits; y++) {
                if(x===0){ // Header
                    const dist = (Math.ceil((event.distance / numSplits) * y)).toString()
                    tmpHeaderVal.push(dist)
                    tmpHeader.widthArr.push(75)
                }
                tempTableData[x].push('')
            }
        }
        setTableData(tempTableData)
        setHeaderValues(tmpHeaderVal)

        for(let x=0; x<athletes.length; x++) {
            for(let y=1; y<=numSplits; y++) {
                if(x===0) {
                    console.log(headerValues[y])
                    tmpHeader.tableHead.push(<TextInput
                        maxLength={5}
                        keyboardType='numeric'
                        value={headerValues[y]}
                        onChangeText={text => {
                            let tmpHeaderVal = headerValues
                            tmpHeaderVal[y] = text

                            setHeaderValues(tmpHeaderVal)
                        }}
                        style={styles.cellText}/>)
                }
                tempTableForm[x].push(<TextInput
                    maxLength={10}
                    value={tableData[x][y]}
                    onChangeText={text => setTableCell(x,y,text)}
                    style={styles.cellText}/>)
            }
        }
        setHeader(tmpHeader)
        setTableForm(tempTableForm);
    }

    function setTableCell(x,y,value) {
        console.log(value)
        if(x === 'head') {
            let tmpHeaderVal = headerValues
            tmpHeaderVal[y] = value

            setHeaderValues(tmpHeaderVal)
        } else if (y === 'new') {
            const column = tableData[x].findIndex((split) => split === '');
            let tempTableData = tableData;
        
            tempTableData[x][column] = value;
            setTableData(tempTableData);
        }
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

    return(
        <ScrollView>
        <View style={styles.container}>
            <Text style={styles.header}>{meet.name}</Text>
            <Text style={styles.header}>{event.name}</Text>
            <View style={{flexDirection: 'row'}}>
                <Text style = {styles.inputHeader}>Num of Splits: </Text>
                <TextInput
                    value={numSplits}
                    onChangeText={(text) => {
                        const value = text.replace(/[^0-9]/g, '')
                        setNumSplits(value)
                    }}
                    keyboardType="numeric"
                    maxLength={2}
                    placeholder='1'
                    placeholderTextColor={'red'}
                    style={styles.inputContainer}
                />
                <TouchableOpacity
                    onPress={generateTable}
                    style={{alignSelf: 'center'}}>
                    <Ionicons name="md-enter-outline" size={24} color="darkgreen" />
                </TouchableOpacity>
            </View>
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
                {athletes.map((athlete, id) => (
                    <TouchableOpacity
                        testID={athlete.id}
                        onPress={() => setTableCell(id, 'new', stopwatch)}
                        style={styles.athleteButton}>
                        <Text style={{fontWeight:'bold'}}>{athlete.name}</Text>
                    </TouchableOpacity>
                ))}
            </View>
        </View>
        <ScrollView horizontal={true} style={{paddingVertical: 20}}>
            <View>
                <Table borderStyle={{borderColor: 'black', borderRadius: 5}}>
                    <Row data={header.tableHead} widthArr={header.widthArr} style={styles.head} textStyle={styles.tableHeader}/>
                </Table>
                <ScrollView style={styles.dataWrapper}>
                    <Table borderStyle={{borderColor: '#C1C0B9'}}>
                        { tableForm.map((dataRow, index) => (
                            <TableWrapper key={index} style={ index%2 ? styles.rowA : styles.rowB}>
                                {dataRow.map((cellData, cellIndex) => (
                                    <Cell 
                                        key={cellIndex}
                                        data={cellData}
                                        style={{width: header.widthArr[cellIndex]}}
                                        textStyle={[{textAlign: 'center', fontWeight: '200' }]}
                                    />
                            ))}
                            </TableWrapper>
                        ))}
                    </Table>
                </ScrollView>
            </View>
        </ScrollView>
        </ScrollView>
    );
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        alignItems: 'center',
        backgroundColor: 'linen',
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