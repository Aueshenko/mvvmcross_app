using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Forms.Views;
using MyMvvmCrossApp1.Core.ViewModels.Home;
using MyMvvmCrossApp1.Core.ViewModels.TaskList;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMvvmCrossApp1.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //[MvxContentPagePresentation(WrapInNavigationPage = true)]
    public partial class TaskListPage : MvxContentPage<TaskListViewModel>
    {
        public TaskListPage()
        {
            InitializeComponent();
        }
        
    }
}
