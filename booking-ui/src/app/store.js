import { configureStore } from '@reduxjs/toolkit';
import userReducer from '../features/User/UserSlice.js'
import apartmentReducer from '../features/Booking/ApartmentSlice.js'
import appointmentReducer from '../features/Booking/Appointment/AppointmentSlice.js'

export const store = configureStore({
  reducer: {
    user : userReducer,
    apartment : apartmentReducer,
    appointment : appointmentReducer
  },
});
