using ToDoApi.Models;

namespace ToDoApi.Interfaces
{
    public interface IToDoRepository
    {
        ToDo GetToDo(int id);
        ICollection<ToDo> GetTodos();
        bool CreateToDo (ToDo todo);
        bool DeleteToDo(ToDo todo);
        bool ToDoExists(int id);
        bool Save();
    }
}
