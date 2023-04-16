using Microsoft.Extensions.Options;
using MongoDB.Driver;
using OpenAPI.Models;

namespace OpenAPI.Services
{
    public class TodoService : ITodoService
    {
        private readonly IMongoCollection<Todo> Todos;

        public TodoService(IDatabaseSettings settings)
        {

            var mongoClient = new MongoClient(
                settings.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                settings.DatabaseName);

            Todos = mongoDatabase.GetCollection<Todo>(
                settings.TodoCollectionName);
        }
        public async Task<List<Todo>> GetAsync() =>
            await Todos.Find(_ => true).ToListAsync();

        public async Task<Todo?> GetAsync(string id) =>
            await Todos.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Todo todo) =>
            await Todos.InsertOneAsync(todo);

        public async Task UpdateAsync(string id, Todo updateTodo) =>
            await Todos.ReplaceOneAsync(x => x.Id == id, updateTodo);

        public async Task RemoveAsync(string id) =>
            await Todos.DeleteOneAsync(x => x.Id == id);

        //public List<Todo> GetTodos()
        //{
        //    return Todos.Find(todo => true).ToList();

        //}

        //public Todo GetTodo(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Todo CreateTodo(Todo todo)
        //{
        //    Todos.InsertOne(todo);
        //    return todo;
        //}

        //public Todo UpdateTodo(Todo todo)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Remove(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
