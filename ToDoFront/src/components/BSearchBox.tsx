import '../styles/BSearchBox.scss';
import '../styles/SearchBox.scss';

export function BSearchBox() {
    
    return (
      <div className={`bbox-container`}>
        <input type="text"  placeholder="Add a task" className='bbox-input sbox-input'/> 
        <button className="b-button button"> </button>
      </div>
    )
}