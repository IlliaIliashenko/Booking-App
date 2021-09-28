import React from 'react'
import { Link,useHistory } from "react-router-dom";
import { createAppointment } from './Appointment/AppointmentSlice';
import { useDispatch } from 'react-redux'
import "./ApartmentList.css"
import tokenService from '../services/token.service';


const AppartmentCard = ({ data }) => {

    const dispatch = useDispatch();
    const history = useHistory();
    const isLogin = tokenService.getUser();


    const createOrder = (e,data) => {
        if (isLogin) {
            debugger;
            e.preventDefault();
            let appointment = {apartmentid:data.id}
            dispatch(createAppointment(appointment))
            history.push({pathname:'/confirmation', state: {detail : data}});
        }
        else{
            history.push('/login');
        }
    }

    return (
        <li class="li-row">
            <article class="box">
                <figure> <a href="#" class="hover-effect popup-gallery">
                    <img width="270" height="270" alt="" src={data.photos[0]} draggable="false" /></a></figure>
                <div class="details"> <span class="price">{data.price}<small>uah</small></span>
                    <h4 class="box-title">{data.name}</h4>
                    <div class="action">
                        <button class="button btn-small" onClick={(e) => createOrder(e,data)}>Заказать</button>
                        <Link class="button btn-small" to={{ pathname: '/details',state: { details: data } }} data-box="37.089072, -8.247880">Детали</Link>
                    </div>
                </div>
            </article>
        </li>
    )
}

export default AppartmentCard