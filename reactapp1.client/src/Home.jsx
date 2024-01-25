import React from 'react'
import { CrudContextProvider, useCrudContext } from './contexts/CrudContext';
import { useEffect } from 'react';
function Home() {
    const { users, getUsers, products, getProducts, orders, getOrders, piorders, getPiorders } = useCrudContext();

    //get data only once
    useEffect(() => {
        getUsers();
        getProducts();
        getOrders();
        getPiorders();
    }, [])
    console.log(users);
    console.log(products);
    //make tables that show all the data from the database
    return (
        <div>
            <h1>Users</h1>
            <table>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    {users.map(user => (
                        <tr key={user.userId}>
                            <td>{user.userId}</td>
                            <td>{user.name}</td>
                        </tr>
                    ))}
                </tbody>
            </table>

            <h1>Products</h1>
            <table>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Price</th>
                    </tr>
                </thead>
                <tbody>
                    {products.map(product => (
                        <tr key={product.productId}>
                            <td>{product.productId}</td>
                            <td>{product.productName}</td>
                            <td>{product.productDescription}</td>
                        </tr>
                    ))}
                </tbody>
            </table>

            <h1>Orders</h1>
            <table>
                <thead>
                    <tr>
                        <th>Order ID</th>
                        <th>Product ID</th>
                    </tr>
                </thead>
                <tbody>
                    {orders.map(order => (
                        <tr key={order.orderId}>
                            <td>{order.orderId}</td>
                            <td>{order.productId}</td>
                            <td>{order.quantity}</td>
                        </tr>
                    ))}
                </tbody>
            </table>

            <h1>PiOrders</h1>
            <table>
                <thead>
                    <tr>
                        <th>PiOrder ID</th>
                        <th>Order ID</th>
                        <th>Product ID</th>
                    </tr>
                </thead>
                <tbody>
                    {piorders.map(piorder => (
                        <tr key={piorder.piOrderId}>
                            <td>{piorder.piOrderId}</td>
                            <td>{piorder.orderId}</td>
                            <td>{piorder.productId}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    )
}

export default Home