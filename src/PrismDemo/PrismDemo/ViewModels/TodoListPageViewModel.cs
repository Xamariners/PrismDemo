using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using PrismDemo.Models;
using PrismDemo.Services;
using Xamarin.Forms;

namespace PrismDemo.ViewModels
{
    public class TodoListPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        private readonly ITodoService _todoService;
        private readonly INavigationService _navigationService;

        private DelegateCommand<ItemTappedEventArgs> _navigateToTodoItem;

        public DelegateCommand AddNewTodoItemCommand => new DelegateCommand(AddItem);

        private ObservableCollection<TodoItem> _todoItems;

        public ObservableCollection<TodoItem> TodoItems
        {
            get { return _todoItems; }
            set { SetProperty(ref _todoItems, value); }
        }
       
        public DelegateCommand<ItemTappedEventArgs> NavigateToTodoItem
        {
            get
            {
                if (_navigateToTodoItem == null)
                {
                    _navigateToTodoItem = new DelegateCommand<ItemTappedEventArgs>(async selectedTodoItem =>
                    {
                        NavigationParameters param = new NavigationParameters {{"todoItem", selectedTodoItem.Item}};
                        await _navigationService.NavigateAsync("TodoItemPage", param);
                    });
                }
                
                return _navigateToTodoItem;
            }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        
        public TodoListPageViewModel(ITodoService todoService, INavigationService navigationService)
        {
            _navigationService = navigationService;
            _todoService = todoService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            var todoItems = await _todoService.GetTodoItems();
            TodoItems = new ObservableCollection<TodoItem>(todoItems);

            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }

        private async void AddItem()
        {
            await _navigationService.NavigateAsync("TodoItemPage");
        }
    }
}
