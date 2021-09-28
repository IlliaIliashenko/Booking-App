import React,{ useEffect,useState } from 'react'
import { useDispatch } from 'react-redux'
import { getApartments } from './ApartmentSlice'
import { createAppointment } from './Appointment/AppointmentSlice';
import { useHistory } from "react-router-dom";
import tokenService from '../services/token.service';
import "./ApartmentDetails.css"




const ApartmentDetails = (props) => {
    const dispatch = useDispatch();
    const [counter,setCounter] = useState(0);
    const isLogin = tokenService.getUser();
    const history = useHistory();
    const { details } = props.location.state


    const createOrder = (e,data) => {
        if (isLogin) {
            e.preventDefault();
            let appointment = {apartmentid:data}
            dispatch(createAppointment(appointment))
            history.push({pathname:'/confirmation', state: {detail : details}});
        }
        else{
            history.push('/login');
        }
    }

    const createList = (data) => {
        const list = [];
        for (const [key,value] of Object.entries(data)) {
            list.push({ key,value })
        }
        return list;
    }

    const renderBlock = (data=details.details) => {
        let list = createList(data);
        return list.map(d => (<p>{d.key} : {d.value}</p>))
    }
    const getPhoto = (id=counter) =>{
        if(id>details.photos.length){
            setCounter(0)
        }
        return details.photos[counter]

    }

    useEffect(() => {
        dispatch(getApartments())
    },[])

    return (
        <div class="wrapper">
            <div class="card">
                <div class="product-left">
                    <div class="header">
                        <h1>{details.name}</h1>
                    </div>
                    <div class="product-main">
                        <div class="focus">
                            <span>Детали</span>
                        </div>
                        {renderBlock()}
                    </div>
                    <div class="product-details">
                        <div class="product-total">
                            <h3>Общая сумма</h3>
                            <p>{details.price}<small>грн</small></p>
                        </div>
                    </div>
                    <div class="product-btns">
                        <button href="#" class="product-add" onClick={(e)=>createOrder(e,details.id)}>Заказать</button>
                    </div>
                </div>
                <div class="product-right">
                    <img src={getPhoto()} alt="" />
                    <div class="product-btns btn">
                    {counter<details.photos.length-1&&<button class="product-add" onClick={()=>setCounter(counter+1)}>Следующая</button>}
                    {counter>0 &&<button class="product-add"onClick={()=>setCounter(counter-1)}>Предыдущая</button>}
                    </div>
                    
                </div>
            </div>
        </div>
    )


}

export default ApartmentDetails