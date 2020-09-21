using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTodo.Models;

namespace XamarinTodo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderAcceptedPage : ContentPage
    {
        private OrderOverView OrderOverView;

        public OrderAcceptedPage(OrderOverView orderOverView)
        {
            OrderOverView = new OrderOverView();
            OrderOverView = orderOverView;

            InitializeComponent();

            LabelCustomerName.Text = OrderOverView.Company;
            LabelCustomerId.Text = OrderOverView.OrderId.ToString();
            LabelAdress.Text = OrderOverView.Street;
            LabelContactPerson.Text = OrderOverView.Name;
            LabelOrderDescription.Text = OrderOverView.OrderDescription;
        }

        private async void AddInfoSwipe_Invoked(object sender, EventArgs e)
        {
            //Här ska ordern uppdateras till Accepterad
            await Navigation.PushAsync(new OrderDoneAddInfoPage(OrderOverView));
        }
    }
}