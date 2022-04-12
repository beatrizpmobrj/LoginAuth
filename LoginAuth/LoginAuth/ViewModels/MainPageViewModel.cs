using LoginAuth.Interfaces;
using LoginAuth.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginAuth.ViewModels
{
    public class MainPageViewModel
    {
        public ICommand Logout { get; private set; }

        private readonly IGoogleManager _googleManager;
        public bool IsLogedIn { get; set; }

        public MainPageViewModel()
        {
            _googleManager = DependencyService.Get<IGoogleManager>();
            Logout = new Command(GoogleLogout);
        }

        private void GoogleLogout()
        {
            _googleManager.Logout();
            IsLogedIn = false;

            Application.Current.MainPage = new Login();


        }

        
       
        
    }
}
