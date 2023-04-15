using Microsoft.AspNetCore.Mvc;
using OpenAPI.Models;
using OpenAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OpenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _service;

        public TodoController(ITodoService service)
        {
            _service = service;
        }
        // GET: api/<TodoController>
        [HttpGet]
        public async Task<List<Todo>> Get()
        {
            return await _service.GetAsync();
        }
        // POST api/<TodoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Todo todo)
        {
            await _service.CreateAsync(todo);

            return CreatedAtAction(nameof(Get), new { id = todo.Id }, todo);
        }
        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Todo updatedTodo)
        {
            var todo = await _service.GetAsync(id);

            if (todo is null)
            {
                return NotFound();
            }

            updatedTodo.Id = todo.Id;

            await _service.UpdateAsync(id, updatedTodo);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var todo = await _service.GetAsync(id);

            if (todo is null)
            {
                return NotFound();
            }

            await _service.RemoveAsync(id);

            return NoContent();
        }
    }
}
