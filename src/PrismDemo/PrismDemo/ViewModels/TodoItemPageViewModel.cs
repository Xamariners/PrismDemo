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
        private string _mode;

        private readonly ITodoService _todoService;
        private readonly MainViewModel _mainViewModel;
        private readonly INavigationService _navigationService;
        


        public TodoItem SelectedTodoItem
        {
            get
            {
                return _mainViewModel.SelectedTodoItem;
            }
            set
            {
                var selectedTodoItem = _mainViewModel.SelectedTodoItem;
                SetProperty(ref selectedTodoItem, value);
            }
        }

        public string Mode
        {
            get { return _mode; }
            set { SetProperty(ref _mode, value); }
        }

        public TodoItem TodoItem
        {
            get { return _todoItem; }
            set { SetProperty(ref _todoItem, value); }
        }
        
        public TodoItemPageViewModel(ITodoService todoService, INavigationService navigationService, MainViewModel mainViewModel)
        {
            _todoService = todoService;
            _navigationService = navigationService;
            _mainViewModel = mainViewModel;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if(parameters.ContainsKey("todoItem"))
                TodoItem = parameters["todoItem"] as TodoItem;

            Mode = parameters["mode"] as string;

            if (Mode == "Add")
                TodoItem = new TodoItem();
        }

        private async void DeleteItem()
        {
            if (Mode == "Add")
                await _navigationService.GoBackAsync();
            else
                await _todoService.DeleteTodoItem(_todoItem);
        }

        private async void UpdateItem()
        {
            if(Mode == "Add")
                await _todoService.AddTodoItem(_todoItem);
            else
                await _todoService.UpdateTodoItem(_todoItem);
        }
        
        private async Task TodoStatusUpdate(string status)
        {
            _todoItem.TodoStatus =(TodoStatus)int.Parse(status);
            await _todoService.UpdateTodoItem(_todoItem);
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
           
        }
    }
}