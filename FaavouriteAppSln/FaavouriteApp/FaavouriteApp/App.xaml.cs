using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FaavouriteApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            NavigationPage navePage= new NavigationPage (new  FavouritesTabbedPage());
            navePage.BackgroundColor= Color.White;
            MainPage = navePage;
        }

        /*protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }*/
    }
}
