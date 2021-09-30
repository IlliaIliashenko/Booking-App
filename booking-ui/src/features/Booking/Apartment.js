import React,{ useEffect,useState } from 'react'
import { useDispatch,useSelector } from 'react-redux'
import { getApartments,selectApartments } from './ApartmentSlice'
import AppartmentCard from './AppartmentCard';
import Select from 'react-select'
import { customStyles } from '../../CustomSelectStyles';
import "./ApartmentList.css"


const FilterOptions = [
    { value: 'all',label: 'All' },
    { value: 'price',label: 'Price' }
]

const Apartment = () => {
    const dispatch = useDispatch();
    const selector = useSelector(selectApartments);
    const [filterOption,setFilterOption] = useState("all");


    const list = selector.apartmentList;
    const paging = selector.pagingModel

    const onSubmit = (pageNumber) => {
        const entity = { filterOption: filterOption,page: pageNumber }
        dispatch(getApartments(entity))
    }

    const getFiltered = (option) => {
        setFilterOption(option);
        const entity = { filterOption: option,page: 1 }
        dispatch(getApartments(entity))
    }
    useEffect(() => {
        dispatch(getApartments({ filterOption: filterOption,page: 1 }))
    },[])

    return (<div class="section">
        <div class="container">
        <Select  styles={customStyles} onChange={(e) => getFiltered(e.value)} options={FilterOptions} />
            <div class="image-carousel style2 flexslider" data-item-width="270" data-item-margin="30">
                <div class="flex-viewport list-container">
                    <ul class="slides image-box hotel listing-style1">
                        {list.length === 0 ? <div>No data yet</div> : list.map(data => (
                            <AppartmentCard data={data} />
                        ))}
                    </ul>
                </div>
            </div>
        </div>
        <div class="btn-section">
            {paging.hasPreviousPage &&
                <button class="page-btn" onClick={() => onSubmit(paging.pageNumber - 1)}>Назад</button>
            }
            {paging.hasNextPage &&
                <button class="page-btn" onClick={() => onSubmit(paging.pageNumber + 1)}>Вперед</button>
            }
        </div>
    </div>)
}

export default Apartment