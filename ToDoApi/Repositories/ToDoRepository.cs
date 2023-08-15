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

        public ICollection<ToDo> GetTodos()
        {
            return _context.ToDo.OrderBy(p => p.Id).ToList();
        }
    }
}
