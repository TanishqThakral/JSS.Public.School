using System.ComponentModel;
using Xamarin.Forms;
using JSS.ViewModels;

namespace JSS.Views
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
