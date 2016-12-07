using Microsoft.Practices.Unity;
using Prism.Unity;
using PrismDemo.Services;
using PrismDemo.Views;
using Xamarin.Forms;

namespace PrismDemo
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            //NavigationService.NavigateAsync("NavigationPage/TodoListPage");
            NavigationService.NavigateAsync("TodoListPage");
        }

        protected override void RegisterTypes()
        {
            //Container.RegisterTypeForNavigation<NavigationPage>();

            Container.RegisterTypeForNavigation<TodoListPage>();
            Container.RegisterTypeForNavigation<TodoItemPage>();
            Container.RegisterType<ITodoService, FakeTodoService>();
        }
    }
}