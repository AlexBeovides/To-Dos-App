import '../styles/TSearchBox.scss';
import '../styles/SearchBox.scss';
import { useState } from 'react';

export function TSearchBox() {
  const [activeButton, setActiveButton] = useState('all'); // Initialize the active button state

  const handleButtonClick = (buttonName: string) => {
    setActiveButton(buttonName); // Update the active button when a button is clicked
  };
  
    return ( 
      
      <div className="nav-container">
        <div className="nav">
          <button
          className={`all nav-button ${activeButton === 'all' ? 'active' : ''}`}
          onClick={() => handleButtonClick('all')}>all</button>
        <button
          className={`completed nav-button ${activeButton === 'completed' ? 'active' : ''}`}
          onClick={() => handleButtonClick('completed')}
        >completed</button>
        <button
          className={`pending nav-button ${activeButton === 'pending' ? 'active' : ''}`}
          onClick={() => handleButtonClick('pending')}
        >pending</button>
        </div>
        <div className={`tbox-container`}>
          <input type="text"  placeholder="Search" className='tbox-input sbox-input'/>
          <button className="t-button button"> </button>
        </div>
      </div> 

      
    )
}