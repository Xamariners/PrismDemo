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
    }
}
