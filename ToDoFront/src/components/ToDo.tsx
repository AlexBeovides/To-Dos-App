import '../styles/ToDo.scss'; 
import '../styles/SearchBox.scss'; 

interface ToDoProps {
    id: number;
    task: string; 
  }

export const ToDo=(props:ToDoProps) => {
    const propId=props.id;
    const propTask=props.task;
    
    return (
      <div className={`todo-container`}>
        <div className="check-container">
            <div className="round">
                <input type="checkbox"  id={`checkbox-${propId}`} />
                {/* onChange={(e) => e.target.checked && e.target.setAttribute("disabled", "true")} */}
                <label htmlFor={`checkbox-${propId}`}></label>
            </div>
        </div>

        <div className="task-container">
          <div  className='todo-task'> {propTask} </div>
           
          <button className="delete-button button"> </button>
        </div>
      </div>
    )
}