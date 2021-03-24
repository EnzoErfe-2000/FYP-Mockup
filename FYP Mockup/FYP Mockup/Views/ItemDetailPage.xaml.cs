using FYP_Mockup.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FYP_Mockup.Views
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