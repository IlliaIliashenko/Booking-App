import React from 'react'
import { useDispatch,useSelector } from 'react-redux'
import { Link } from "react-router-dom";
import tokenService from './features/services/token.service';
import { selectUser } from './features/User/UserSlice';



const NavBar = () => {

    const selector = useSelector(selectUser);
    const isLogin =  selector.isUser;

    return (<ul>
        <li><Link to="/Apartments">Квартиры</Link></li>
        <li>{isLogin&&<Link to="/appointments">Записи на просмотр</Link>}</li>
        <li>{isLogin?<Link to="/logout">Logout</Link>:<Link to="/login">Login</Link>}</li>
        <li>{!isLogin&&<Link to="/register">Register</Link>}</li>
    </ul>

    )
}

export default NavBar