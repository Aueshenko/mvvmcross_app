using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MyMvvmCrossApp1.Core.Services;
using MyMvvmCrossApp1.Core.ViewModels.Home;

namespace MyMvvmCrossApp1.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();

            Mvx.IoCProvider.RegisterType<AuthService>();
            Mvx.IoCProvider.RegisterType<TaskListService>();
        }
    }
}
