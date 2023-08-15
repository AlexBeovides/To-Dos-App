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

        [HttpGet("/api/ToDo/GetToDoById/{todoId}", Name = "")]
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

        [HttpGet("/api/ToDo/GetAllToDos")]
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

        [HttpPost("/api/ToDo/CreateToDo")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateToDo([FromBody] string todoTask)
        {
            if(todoTask == null)
            {
                return BadRequest(ModelState);
            }

            if(!_toDoRepository.CreateToDo (todoTask))
            {
                ModelState.AddModelError("", "Something went wrong while savin");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }

        [HttpPut("/api/ToDo/UpdateToDo/{todoId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateToDo(int todoId, [FromBody] ToDo updatedToDo)
        {
            if (updatedToDo == null)
                return BadRequest(ModelState);

            if (todoId != updatedToDo.Id)
                return BadRequest(ModelState);

            if (!_toDoRepository.ToDoExists(todoId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            if (!_toDoRepository.UpdateToDo(updatedToDo))
            {
                ModelState.AddModelError("", "Something went wrong updating category");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }


        [HttpDelete("/api/ToDo/DeleteToDo/{todoId}")]
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
