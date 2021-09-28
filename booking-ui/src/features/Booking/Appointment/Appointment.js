import React,{ useEffect,useState } from 'react'
import { useDispatch,useSelector } from 'react-redux'
import { deleteAppointment,editAppointment,getAppointments,selectAppointments } from './AppointmentSlice';
import "./test.css"



const Appointment = () => {
    const dispatch = useDispatch();
    const selector = useSelector(selectAppointments);
    const list = selector.appointmentList;
    const [appointment,setAppointment] = useState({ id: 0 });
    const [state,setState] = useState(null);


    const onSubmit = () => {
        dispatch(editAppointment(appointment));
        setAppointment({ id: 0 });
        setState(null);


    }
    const handleAppontment = (data) => {
        setAppointment({ ...data,visited: true });
        setState(data.id)
    }

    const onDell = (id) => {
        dispatch(deleteAppointment(id))
    }

    useEffect(() => {
        dispatch(getAppointments())
    },[])

    return (
        <table>
            <thead>
                <tr>
                    <th>Дата</th>
                    <th>Квартира</th>
                    <th>Посещено</th>
                    <th>Действия</th>
                </tr>
            </thead>
            <tbody>
                {list.length === 0 ? <div>No data yet</div> : list.map(data => (
                    <tr>
                        <td>{data.date}</td>
                        <td>{data.apartment}</td>
                        <td>{data.visited ? "Посещено" : "Не посещено"}</td>
                        <td>{!data.visited && state != data.id && <button onClick={() => handleAppontment(data)}>Посещено</button>}
                        {state == data.id && <button onClick={() => onSubmit()}>Сохранить</button>}
                        {state == data.id && <button onClick={() => onDell(data.id)} >Удалить</button>}</td>
                    </tr>
                ))}
            </tbody>
        </table>)
}

export default Appointment