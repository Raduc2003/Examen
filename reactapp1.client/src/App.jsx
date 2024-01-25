import { useEffect, useState } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import { CrudContextProvider} from './contexts/CrudContext';
import Home from './Home';
import './App.css';

function App() {

    return (
        <CrudContextProvider>
            <Router>
                <Routes>
                    <Route path="/" element={<Home/>}/>
                </Routes>
            </Router>


        </CrudContextProvider>
       
    );
    
    
}

export default App;