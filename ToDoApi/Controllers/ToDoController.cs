using Microsoft.AspNetCore.Mvc;
using ToDoApi.Interfaces;
using ToDoApi.Models;

namespace ToDoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : Controller
    {
        private readonly IToDoRepository _toDoRepository;
        
        public ToDoController(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ToDo>))]
        public IActionResult GetToDo()
        {
            var todos= _toDoRepository.GetTodos();
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(todos);
        }


    }
}
