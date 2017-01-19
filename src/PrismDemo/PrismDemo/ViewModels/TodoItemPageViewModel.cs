using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Navigation;
using PrismDemo.Models;
using PrismDemo.Services;

namespace PrismDemo.ViewModels
{
    public class TodoItemPageViewModel : BindableBase, INavigationAware
    {

        public DelegateCommand UpdateItemCommand => new DelegateCommand(UpdateItem);
        public DelegateCommand DeleteItemCommand => new DelegateCommand(DeleteItem);
        public DelegateCommand<string> TodoStatusUpdateCommand => new DelegateCommand<string>((status) => TodoStatusUpdate(status));

        private TodoItem _todoItem;
        private readonly ITodoService _todoService;

        public TodoItem TodoItem
        {
            get { return _todoItem; }
            set { SetProperty(ref _todoItem, value); }
        }


        public TodoItemPageViewModel(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            TodoItem = parameters["todoItem"] as TodoItem;
        }

        private async void DeleteItem()
        {
            await _todoService.DeleteTodoItem(_todoItem);
        }

        private async void UpdateItem()
        {
            await _todoService.UpdateTodoItem(_todoItem);
        }
        
        private async Task TodoStatusUpdate(string status)
        {
            _todoItem.TodoStatus =(TodoStatus)int.Parse(status);
            await _todoService.UpdateTodoItem(_todoItem);
        }
    }
}