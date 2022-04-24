import { Pressable, View } from 'react-native';
import { Ionicons } from '@expo/vector-icons';

function HeadButton({iconName}, size, pressHandler) {
    return (
        <Pressable 
            onPress={pressHandler} 
            style={({ pressed }) => pressed && styles.onPressed}
        >
            <View style={styles.button}>
                <Ionicons name={iconName} />
            </View>
        </Pressable>
    );
}

export default HeadButton;

const styles = StyleSheet.create({
    button: {
        padding: 5,
        margin: 5
    },
    onPressed: {
        opacity: 0.7
    }
})