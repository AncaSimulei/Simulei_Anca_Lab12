using Simulei_Anca_Lab12_xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Simulei_Anca_Lab12_xamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}