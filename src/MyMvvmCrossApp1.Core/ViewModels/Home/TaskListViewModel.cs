using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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

        public Task<List<string>> TaskNames
        {
            get => _taskNames;
            set => SetProperty(ref _taskNames, value);
        }
        //public Task<List<string>> ShowTasks()
        //{
        //    TaskNames = _taskListService.ShowTaskList();
        //    return TaskNames;
        //}

        private Task<List<string>> _taskNames;
        private readonly TaskListService _taskListService;
    }
}
