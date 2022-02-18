import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from "axios";
import { Header, List } from 'semantic-ui-react';

function App() {

 const [activity, setActivities] = useState([]);

 useEffect(() => {

  axios.get('http://localhost:5001/api/activities').then(res => {
   
   setActivities(res.data);

  } )
 })

  
  return (
    <div  >

      <Header as='h20' icon='users' content='Reactivities'/>
       
       <List>
       {activity.map((activity: any) => (
        <List.Item key={activity.id}>
           {activity.title}

        </List.Item>


       ))}

       </List>

      
 
  
       
    </div>
  );
}

export default App;
