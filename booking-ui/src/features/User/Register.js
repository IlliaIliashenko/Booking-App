import React,{ useState } from 'react'
import { useDispatch, } from 'react-redux'
import { useHistory } from "react-router-dom";
import { register } from './UserSlice'
import "./Login.css"

const Register = () => {

    const dispatch = useDispatch()
    const [user,setUser] = useState();
    const history = useHistory();

    const onSubmit = (e) => {
        e.preventDefault();
        dispatch(register(user));

    }

    return <div className="form">
        <form className="register-form" onSubmit={onSubmit}>
        <h2>Sign In</h2>
            <input onChange={(e) => setUser({ ...user,history:history,firstName: e.target.value })} placeholder="FirstName" />
            <input onChange={(e) => setUser({ ...user,history:history,lastName: e.target.value })} placeholder="LastName" />
            <input onChange={(e) => setUser({ ...user,history:history,email: e.target.value })} placeholder="Email" />
            <input type="password" onChange={(e) => setUser({ ...user,history:history,password: e.target.value })} placeholder="Password" />
            <input type="password" onChange={(e) => setUser({ ...user,history:history,confirmPassword: e.target.value })} placeholder="ConfirmPassword" />
            <button type="submit"> sign in</button>
        </form>
    </div>
}

export default Register;