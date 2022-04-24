import React, { useEffect } from 'react';
import { FlatList, Text, View, StyleSheet } from 'react-native';
import ShadowBox from './ShadowBox';

function EquipmentList(equipment) {
    function renderEquipmentItem(itemData) {
        return (
            <ShadowBox />
        );
    }

    return (
        <FlatList 
            data={equipment}
            renderItem={renderEquipmentItem}
            keyExtractor={(item) => item.id }
        />
    );
}

export default EquipmentList;