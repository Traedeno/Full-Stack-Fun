import React from 'react';
import './App.css';
import Header from './Header';
import FoodList from './Food/BowlerList';

function App() {
  return (
    <div className="App">
      <Header title="Local Bowling Teams" />
      <FoodList />
    </div>
  );
}

export default App;
