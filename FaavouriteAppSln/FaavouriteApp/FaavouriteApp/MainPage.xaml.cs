using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FaavouriteApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async  void Contacts_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new Contacts());
        }
    }
}
