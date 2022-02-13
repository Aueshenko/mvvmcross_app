using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Commands;
using MyMvvmCrossApp1.Core.Services;

namespace MyMvvmCrossApp1.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel 
    {
        //SomeService service in args
        public HomeViewModel(AuthService authService)
        {
            _authService = authService;
        }


        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand SomeCommand => new MvxCommand(
            async () => await _authService.Authorize(Email, Password));




        private string _email = "";
        private string _password = "";
        private readonly AuthService _authService;
    }
}
