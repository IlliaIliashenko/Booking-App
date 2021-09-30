import React from 'react'
import { useLocation,useHistory } from "react-router-dom";
import "./AppointmentConfirmation.css"


const AppointmentConfirmation = props => {
const location = useLocation();
const history = useHistory();
const { detail } = location.state

    return (
        <div className="form">
        <form>
            <h2>Ваш заказ принят</h2>
            <div>{detail.name}</div>
            <div>{detail.price}грн</div>
            <button onClick={()=>history.push('/apartments')}>Вернуться к апартаментам</button>
            <button onClick={()=>history.push('/appointments')}>Перейти к истории просмотров</button>
        </form>
    </div>
    )
}

export default AppointmentConfirmation