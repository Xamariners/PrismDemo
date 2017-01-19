using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PrismDemo.Models;

namespace PrismDemo.Services
{
    public class TodoService : ITodoService
    {
        public async Task<List<TodoItem>> GetTodoItems()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync("url to todo date in cloud");
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception("error getting data");
                    }
                    return await response.Content.ReadAsAsync<List<TodoItem>>();
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception("error getting data", ex);
                }
            }
        }

        public Task<bool> DeleteTodoItem(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public Task<TodoItem> UpdateTodoItem(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public Task<TodoItem> AddTodoItem(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}