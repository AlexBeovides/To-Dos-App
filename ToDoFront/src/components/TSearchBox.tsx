import '../styles/TSearchBox.scss';
import '../styles/SearchBox.scss';

export function TSearchBox() {
    
    return (
      <div className={`tbox-container`}>
        <input type="text"  placeholder="Search" className='tbox-input sbox-input'/>
         
      </div>
    )
}