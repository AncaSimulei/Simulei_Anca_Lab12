using Simulei_Anca_Lab12_xamarin.ViewModels;
using Simulei_Anca_Lab12_xamarin.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Simulei_Anca_Lab12_xamarin
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
