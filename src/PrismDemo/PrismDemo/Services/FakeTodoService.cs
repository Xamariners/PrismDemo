using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismDemo.Data;
using PrismDemo.Models;

namespace PrismDemo.Services
{
    public class FakeTodoService : ITodoService
    {
        public async Task<List<TodoItem>> GetTodoItems()
        {
            return FakeTodoData.FakeData.OrderBy(x => x.Name).ToList();
        }

        public async Task<bool> DeleteTodoItem(TodoItem item)
        {
            return FakeTodoData.FakeData.Remove(item);
        }

        public async Task<TodoItem> UpdateTodoItem(TodoItem item)
        {
            var existing = FakeTodoData.FakeData.FirstOrDefault(x => x.Id == item.Id);
            await DeleteTodoItem(existing);
            FakeTodoData.FakeData.Add(item);
            return item;
        }

        public async Task<TodoItem> AddTodoItem(TodoItem item)
        {
            FakeTodoData.FakeData.Add(item);
            return item;
        }
    }
}
