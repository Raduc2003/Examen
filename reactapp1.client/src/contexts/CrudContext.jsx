import { useContext,createContext,useState } from "react";
import axios from "axios";

const CrudContext = createContext();

export  const useCrudContext = () => {
    
    const crudContext = useContext(CrudContext);
    if(!crudContext){
        throw new Error("useCrudContext must be used within CrudContextProvider");
    }
    return crudContext;
}


export const CrudContextProvider = ({children}) => {

    const [users,setUsers] = useState([]);
    const [products,setProducts] = useState([]);
    const [orders,setOrders] = useState([]);
    const [piorders,setPiorders] = useState([]);

    const getUsers = async () => {
        try {
            const response = await axios.get("https://localhost:7042/api/Generic/users");
            setUsers(response.data);
        } catch (error) {
            console.log(error);
        }
    }
    const getProducts = async () => {
        try {
            const response = await axios.get("https://localhost:7042/api/Generic/products");
            setProducts(response.data);
        } catch (error) {
            console.log(error);
        }
    }
    const getOrders = async () => {
        try {
            const response = await axios.get("https://localhost:7042/api/Generic/orders");
            setOrders(response.data);
        } catch (error) {
            console.log(error);
        }
    }
    const getPiorders = async () => {
        try {
            const response = await axios.get("https://localhost:7042/api/Generic/piorders");
            setPiorders(response.data);
        } catch (error) {
            console.log(error);
        }
    }
    const state = {
        users,
        products,
        orders,
        piorders,
        getUsers,
        getProducts,
        getOrders,
        getPiorders
    }

    return (
        <CrudContext.Provider value={state}>
            {children}
        </CrudContext.Provider>
    );


}


