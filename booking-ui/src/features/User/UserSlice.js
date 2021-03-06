import { createSlice,createAsyncThunk } from "@reduxjs/toolkit";
import api from '../services/api'
import tokenService from "../services/token.service";
import TokenService from "../services/token.service";

export const login = createAsyncThunk(
    'user/login',
    async (user) => {
        await api
            .post('/Authentication/login',user)
            .then(response => {
                if (response.data.accessToken) {
                    TokenService.setUser(response.data);
                    user.history.push('/apartments');
                }
            });

    }
)

export const register = createAsyncThunk(
    'user/register',
    async (user) => {
        await api
            .post('/Authentication/register',user)
            .then(response=>{
                user.history.push('/login');
            })

    }
)

const userSlice = createSlice({
    name: 'user',
    initialState: {
        status: null,
        isUser: tokenService.getUser(),
    },
    reducers: {
        logout: (state, {payload}) => {
            TokenService.removeUser();
            state.isUser = false
            payload.push('/login');
        },
        getCurrentUser: () => {
            return TokenService.getUser();
        },
    },

    extraReducers: {
        [register.pending]: (state) => {
            state.status = 'loading'
        },
        [register.fulfilled]: (state) => {
            state.status = 'success'
        },
        [register.rejected]: (state) => {
            state.status = 'rejected'
        },
        [login.pending]: (state) => {
            state.status = 'loading'
        },
        [login.fulfilled]: (state) => {
            state.status = 'success'
            state.isUser = tokenService.getUser()
        },
        [login.rejected]: (state) => {
            state.status = 'rejected'
        },
    }
})

export const { getCurrentUser, logout } = userSlice.actions;

export const selectUser = ({ user }) => user;

export default userSlice.reducer