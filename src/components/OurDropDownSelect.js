import React from 'react';
import { View, StyleSheet} from 'react-native';
import Colors from '../constants/ColorThemes';
import MultiSelect from 'react-native-multiple-select';

const OurDropDownSelect = props => {
    return (
        <View style={styles.container}>
            <MultiSelect
                hideTags
                items={props.items}
                uniqueKey="id"
                // ref={multiSelectRef}
                onSelectedItemsChange={(selectedItems) => props.onItemsChange(selectedItems)}
                selectedItems={props.selectedItems}
                selectText={"Pick "+props.itemName}
                searchInputPlaceholderText={"Search "+props.itemName}
                onChangeInput={ (text)=> console.log(text)}
                // altFontFamily="ProximaNova-Light"
                tagRemoveIconColor="#CCC"
                tagBorderColor="#CCC"
                tagTextColor="#CCC"
                selectedItemTextColor="darkgreen"
                selectedItemIconColor="darkgreen"
                itemTextColor="#000"
                displayKey="name"
                searchInputStyle={{ color: '#CCC' }}
                submitButtonColor="darkgreen"
                submitButtonText="Close"
            />
        </View>
    );
};

const styles = StyleSheet.create({
    container: {
        paddingVertical: 20,
        paddingHorizontal: '10%'
        // alignItems: 'center'
    }
});

export default OurDropDownSelect;