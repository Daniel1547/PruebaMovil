using System.ComponentModel;
using Xamarin.Forms;
using PruebaMovil.ViewModels;

namespace PruebaMovil.Views
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