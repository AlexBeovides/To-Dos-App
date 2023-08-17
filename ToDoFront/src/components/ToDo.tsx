import '../styles/ToDo.scss'; 

interface ToDoProps {
    id: number;
    task: string; 
  }

export const ToDo=(props:ToDoProps) => {
    const propId=props.id;
    const propTask=props.task;
    
    return (
      <div className={`todo-container`}>

        <div className="container">
            <div className="round">
                <input type="checkbox"  id={`checkbox-${propId}`} />
                {/* onChange={(e) => e.target.checked && e.target.setAttribute("disabled", "true")} */}
                <label htmlFor={`checkbox-${propId}`}></label>
            </div>
        </div>

        <div  className='todo-task'> {propTask} </div>
      </div>
    )
}