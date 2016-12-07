using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismDemo.Models;

namespace PrismDemo.Services
{
    public interface ITodoService
    {
        Task<List<TodoItem>> GetTodoItems();
    }
}