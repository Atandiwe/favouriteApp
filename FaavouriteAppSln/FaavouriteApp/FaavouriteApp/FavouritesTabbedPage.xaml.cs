using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FaavouriteApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavouritesTabbedPage : TabbedPage
    {
        public FavouritesTabbedPage()
        {
            InitializeComponent();

            Children.Add(new Contacts());
        
            Children.Add(new Favourites());



        }
    }
}