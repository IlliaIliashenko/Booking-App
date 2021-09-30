import React from 'react'
import { useDispatch } from 'react-redux'
import { logout} from './UserSlice'
import { useHistory } from "react-router-dom";
import "./Login.css"



const Logout = () => {

    const dispatch = useDispatch()
    const history = useHistory();

    const onSubmit = (e) => {
        e.preventDefault();
        dispatch(logout(history));

    }

    return (
        <div className="form">
            <form className="register-form" onSubmit={onSubmit}>
                <h2>Log Out</h2>
                <button type="submit">Log Out</button>
            </form>
        </div>
    )
}

export default Logout