using System.ComponentModel;
using Xamarin.Forms;
using MockXamTodo.ViewModels;

namespace MockXamTodo.Views
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