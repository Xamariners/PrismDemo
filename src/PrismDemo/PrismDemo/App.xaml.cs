using Microsoft.Practices.Unity;
using Prism.Unity;
using PrismDemo.Services;
using PrismDemo.Views;

namespace PrismDemo
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("TodoListPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<TodoListPage>();
            Container.RegisterTypeForNavigation<TodoItemPage>();
            Container.RegisterType<ITodoService, FakeTodoService>();
        }
    }
}