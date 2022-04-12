using LoginAuth.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginAuth.ViewModels
{
    public class LoginViewModel
    {
        private readonly IGoogleManager _googleManager;
       
        public ICommand Login { get; private set; }

        public LoginViewModel()
        {
            _googleManager = DependencyService.Get<IGoogleManager>();
            Login = new Command(GoogleLogin);
        
        }


        private void GoogleLogin()
        {
            _googleManager.Login();
        }
    }
}
