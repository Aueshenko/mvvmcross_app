using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MyMvvmCrossApp1.Core.Services;

namespace MyMvvmCrossApp1.Core.ViewModels.Home
{
    public class HomeViewModel : MvxViewModel
    {
        public HomeViewModel(AuthService authService, IMvxNavigationService navigationService)
        {
            _authService = authService;
            _navigationService = navigationService;
        }

        public string Login
        {
            get => _login;
            set => SetProperty(ref _login, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public ICommand AuthCommand => new MvxCommand(

            async () => { if (await _authService.Authorize(Login, Password) == true) { await _navigationService.Navigate<TaskListViewModel>(); } });




        private string _login;
        private string _password;
        private readonly AuthService _authService;
        private readonly IMvxNavigationService _navigationService;
    }
}
