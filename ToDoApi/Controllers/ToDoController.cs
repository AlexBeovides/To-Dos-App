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

        [HttpGet("{todoId}")]
        [ProducesResponseType(200, Type = typeof(ToDo))]
        public IActionResult GetToDo(int todoId)
        {
            if (!_toDoRepository.ToDoExists(todoId))
            {
                return NotFound();
            }

            var todo = _toDoRepository.GetToDo(todoId);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(todo);
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ToDo>))]
        public IActionResult GetToDos()
        {
            var todos= _toDoRepository.GetTodos();
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(todos);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateToDo([FromBody] string todoTask)
        {
            if(todoTask == null)
            {
                return BadRequest(ModelState);
            }

            var todoToCreate = new ToDo
            {
                Task = todoTask,
                CreatedAt=DateTime.Now
            };

            if(!_toDoRepository.CreateToDo (todoToCreate))
            {
                ModelState.AddModelError("", "Something went wrong saving toDo");
            }

            return NoContent();
        }



        [HttpDelete("{todoId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult DeleteToDo(int todoId)
        {
            if(!_toDoRepository.ToDoExists(todoId))
            {
                return NotFound();
            }

            var toDoToDelete = _toDoRepository.GetToDo(todoId);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            if(!_toDoRepository.DeleteToDo(toDoToDelete))
            {
                ModelState.AddModelError("", "Something went wrong deleting toDo");
            }

            return NoContent();
        }



    }
}
