import React from 'react';
import './App.css';
import {
  BrowserRouter as Router,
  Switch,
  Route,
} from "react-router-dom";
import Register from './features/User/Register';
import Login from './features/User/Login';
import Logout from './features/User/Logout';
import Apartment from './features/Booking/Apartment';
import ApartmentDetails from './features/Booking/ApartmentDetails';
import Appointment from './features/Booking/Appointment/Appointment';
import NavBar from './NavBar';
import AppointmentConfirmation from './features/Booking/Appointment/AppointmentConfirmation';


function App() {


  return (
    <div className="App">
      <Router>
      <header>
        <h1 id="logo">Аренда жилья</h1>
        <nav>
            <NavBar />
        </nav>
      </header>
      <div>
        <Switch>
          <Route path="/register">
            <Register />
          </Route>
          <Route path="/login">
            <Login />
          </Route>
          <Route path="/logout">
            <Logout />
          </Route>
          <Route path="/apartments">
            <Apartment />
          </Route>
          <Route path="/Confirmation">
            <AppointmentConfirmation />
          </Route>
          <Route path="/details" component={ApartmentDetails} />
          <Route path="/appointments" component={Appointment} />
          <Route path="/">
            <Apartment />
          </Route>
        </Switch>
      </div>
      </Router>
    </div>
  );
}

export default App;
