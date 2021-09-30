import { createSlice,createAsyncThunk } from "@reduxjs/toolkit";
import api from "../../services/api";

export const getAppointments = createAsyncThunk(
    'appointment/getAppointment',
    async () => {
        const { data } = await api
            .get('/Appointment')
        return data
    }
)

export const editAppointment = createAsyncThunk(
    'appointment/editAppointment',
    async (entity,{dispatch}) => {
        await api
            .put('/Appointment',entity)
        dispatch(getAppointments())
    }
)

export const createAppointment = createAsyncThunk(
    'appointment/createAppointment',
    async (appointment,{dispatch}) => {
        await api
            .post('/Appointment', appointment)
        dispatch(getAppointments())
    }
)

export const deleteAppointment = createAsyncThunk(
    'appointment/deleteAppointment',
    async (appointmentId,{dispatch}) => {
        await api
            .delete('/Appointment/'+appointmentId)
        dispatch(getAppointments())
    }
)

const appointmentSlice = createSlice({
    name: 'appointment',
    initialState: {
        appointmentList: [],
        status: null,
    },
    extraReducers: {
        [getAppointments.pending]: (state,action) => {
            state.status = 'loading'
        },
        [getAppointments.fulfilled]: (state,{ payload }) => {
            state.appointmentList = payload
            state.status = 'success'
        },
        [getAppointments.rejected]: (state) => {
            state.status = 'rejected'
        },
        [editAppointment.pending]: (state) => {
            state.status = 'loading'
        },
        [editAppointment.fulfilled]: (state) => {
            state.status = 'success'
        },
        [editAppointment.rejected]: (state) => {
            state.status = 'rejected'
        },
        [createAppointment.pending]: (state) => {
            state.status = 'loading'
        },
        [createAppointment.fulfilled]: (state) => {
            state.status = 'success'
        },
        [createAppointment.rejected]: (state) => {
            state.status = 'rejected'
        },
        [deleteAppointment.pending]: (state) => {
            state.status = 'loading'
        },
        [deleteAppointment.fulfilled]: (state) => {
            state.status = 'success'
        },
        [deleteAppointment.rejected]: (state) => {
            state.status = 'rejected'
        },
    }
})

export const selectAppointments = ({ appointment }) => appointment;

export default appointmentSlice.reducer