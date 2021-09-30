import { createSlice,createAsyncThunk } from "@reduxjs/toolkit";
import api from '../services/api'

export const getApartments = createAsyncThunk(
    'apartment/getApartments',
    async (model) => {
        const { data } = await api
            .get('/Apartment/'+model.filterOption+'/'+model.page)
        return data
    }
)

const apartmentSlice = createSlice({
    name: 'apartment',
    initialState: {
        apartmentList: [],
        pagingModel : {},
        status: null,
    },
    extraReducers: {
        [getApartments.pending]: (state,action) => {
            state.status = 'loading'
        },
        [getApartments.fulfilled]: (state,{ payload }) => {
            state.apartmentList = payload.apartments
            state.pagingModel = payload.pageModel
            state.status = 'success'
        },
        [getApartments.rejected]: (state) => {
            state.status = 'rejected'
        }
    }
})

export const selectApartments = ({ apartment }) => apartment;

export default apartmentSlice.reducer