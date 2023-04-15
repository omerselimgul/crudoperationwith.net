using OpenAPI.Models;

namespace OpenAPI.Services
{
    public interface ITodoService
    {
        //List<Todo> GetTodos();
        //Todo GetTodo(int id);
        //Todo CreateTodo(Todo todo);
        //Todo UpdateTodo(Todo todo);
        //void Remove(int id);
        public Task<List<Todo>> GetAsync();

        public Task<Todo?> GetAsync(string id);

        public Task CreateAsync(Todo todo);

        public Task UpdateAsync(string id, Todo updateTodo);

        public Task RemoveAsync(string id);
    }
}
