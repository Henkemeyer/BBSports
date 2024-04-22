import { configureStore } from '@reduxjs/toolkit';
import { createSlice } from '@reduxjs/toolkit';

const userIdSlice = createSlice({
    name: 'userId',
    initialState: {
        userId: '1'
    },
    reducers: {
        login: (state, action) => {
            state.userId = action.payload;
            console.log(state.userId)
        },
        logout: (state, action) => {
            state.userId = '0';
        }
    }
});

export const login = userIdSlice.actions.login;
export const logout = userIdSlice.actions.logout;

export const store = configureStore({
    reducer: {
        UserId: userIdSlice.reducer
    }
});