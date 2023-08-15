using ToDoApi.Data;
using ToDoApi.Interfaces;
using ToDoApi.Models;

namespace ToDoApi.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly AppDbContext _context;
        public ToDoRepository(AppDbContext context)
        {
            _context = context;
        }
        public ToDo GetToDo(int id)
        {
            return _context.ToDo.Where(p=>p.Id==id).FirstOrDefault();
        }
        public ICollection<ToDo> GetTodos()
        {
            return _context.ToDo.OrderBy(p => p.Id).ToList();
        }
        public bool CreateToDo (ToDo todo)
        {
            _context.Add(todo);
            return Save();
        }
        public bool DeleteToDo(ToDo todo)
        {
            _context.Remove(todo);
            return Save();
        }
        
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool ToDoExists(int id)
        {
            return _context.ToDo.Any(p => p.Id == id);
        }

    }
}
