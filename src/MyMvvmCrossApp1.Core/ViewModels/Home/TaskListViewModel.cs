using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;
using MyMvvmCrossApp1.Core.Services;

namespace MyMvvmCrossApp1.Core.ViewModels.Home
{
    public class TaskListViewModel : MvxViewModel
    {
        public TaskListViewModel(TaskListService taskListService)
        {
            _taskListService = taskListService;
        }
        
        private readonly TaskListService _taskListService;

    }
}
