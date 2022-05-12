using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FaavouriteApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhoneDialer : ContentPage
    {
        public PhoneDialer()
        {
            InitializeComponent();
        }
        public class PhoneDialerTest
        {
            public void PlacePhoneCall(string number)
            {
                try
                {
                    PhoneDialer.Open(number);
                }
                catch (ArgumentNullException)
                {
                    // Number was null or white space
                }
                catch (FeatureNotSupportedException ex)
                {
                    // Phone Dialer is not supported on this device.
                }
                catch (Exception ex)
                {
                    // Other error has occurred.
                }
            }
        }
        //private void Button_Clicked(object, EventArgs e)

        private static void Open(string number)
        {
            throw new NotImplementedException();
        }
    }
    
}