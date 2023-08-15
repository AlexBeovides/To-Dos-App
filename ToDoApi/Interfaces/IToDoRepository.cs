using ToDoApi.Models;

namespace ToDoApi.Interfaces
{
    public interface IToDoRepository
    {
        ICollection<ToDo> GetTodos();
    }
}
