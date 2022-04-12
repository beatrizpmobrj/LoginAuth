using LoginAuth.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginAuth
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           // MainPage = new MainPage();
            MainPage = new Login();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
