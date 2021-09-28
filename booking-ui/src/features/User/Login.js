import React,{ useState } from 'react'
import { useDispatch } from 'react-redux'
import { useHistory } from "react-router-dom";
import { login} from './UserSlice'
import "./Login.css"



const Login = () => {
    const dispatch = useDispatch()
    const [user,setUser] = useState();
    const history = useHistory();

    const onSubmit = (e) => {
        e.preventDefault();
        dispatch(login(user));

    }

    return (
        <div className="form">
        <form className="register-form" onSubmit={onSubmit}>
            <h2>Sign Up</h2>
            <input onChange={(e) => setUser({ ...user, history:history,login: e.target.value })} placeholder="Login" />
            <input type="password" onChange={(e) => setUser({ ...user, history:history,password: e.target.value })} placeholder="Password" />
            <button type="submit"> sign up</button>
        </form>
    </div>
    )
 

}

export default Login