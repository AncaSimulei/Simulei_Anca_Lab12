using Simulei_Anca_Lab12_xamarin.Services;
using Simulei_Anca_Lab12_xamarin.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Simulei_Anca_Lab12_xamarin.Data;

namespace Simulei_Anca_Lab12_xamarin
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }

        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
