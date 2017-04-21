using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Microsoft.Practices.Unity;
using Prism.Unity;
using PrismDemo.Services;
using PrismDemo.ViewModels;
using PrismDemo.Views;
using Xamarin.Forms;

namespace PrismDemo
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null)
            : base(initializer)
        {

            MobileCenter.Start(typeof(Analytics), typeof(Crashes));
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
          
            NavigationService.NavigateAsync("NavigationPage/TodoListPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();

            Container.RegisterTypeForNavigation<TodoListPage>();
            Container.RegisterTypeForNavigation<TodoItemPage>();
            Container.RegisterType<ITodoService, FakeTodoService>();
            Container.RegisterInstance(new MainViewModel(), new ContainerControlledLifetimeManager());
        }
    }
}