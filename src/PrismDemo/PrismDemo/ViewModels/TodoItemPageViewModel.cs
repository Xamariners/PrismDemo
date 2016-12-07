using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using PrismDemo.Models;

namespace PrismDemo.ViewModels
{
    public class TodoItemPageViewModel : BindableBase, INavigationAware
    {

        private TodoItem _todoItem;
        public TodoItem TodoItem
        {
            get { return _todoItem; }
            set { SetProperty(ref _todoItem, value); }
        }
        public TodoItemPageViewModel()
        {
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            TodoItem = parameters["todoItem"] as TodoItem;
        }
    }
}