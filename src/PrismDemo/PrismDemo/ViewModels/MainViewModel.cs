using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using PrismDemo.Models;

namespace PrismDemo.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private TodoItem _selectedTodoItem;

        public TodoItem SelectedTodoItem 
        {
            get { return _selectedTodoItem; }
            set { SetProperty(ref _selectedTodoItem, value); }
        }

        public string Name { get; set; }
    }
}
