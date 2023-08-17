import '../styles/TopSection.scss';
import { TSearchBox } from './TSearchBox';

export function TopSection() {
    
    return (
      <div className={`top-section`}>
        <div className='logo-container'>MyTasks</div>
        <TSearchBox></TSearchBox>

      </div>
    )
}