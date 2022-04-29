import { TouchableOpacity, StyleSheet, View } from 'react-native';
import { Ionicons } from '@expo/vector-icons';

function HeaderButton({ iconName, size, pressHandler }) {
// 
// This shit doesn't work. Added manually
// 
    return (
        <TouchableOpacity 
            onPress={() => {pressHandler}}
            style={({ pressed }) => pressed && styles.onPressed}
        >
            <Ionicons name={iconName} size={size} color="green" />
        </TouchableOpacity>
    );
}

export default HeaderButton;

const styles = StyleSheet.create({
    button: {
        padding: 5,
        margin: 5
    },
    onPressed: {
        opacity: 0.7
    }
})