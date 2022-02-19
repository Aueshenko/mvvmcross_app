using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using MyMvvmCrossApp1.Core.Services;

namespace MyMvvmCrossApp1.Core.ViewModels.TaskList
{
    public class TaskListViewModel : MvxViewModel
    {
        public TaskListViewModel(TaskListService taskListService)
        {
            _taskListService = taskListService;
        }

        public MvxObservableCollection<string> TaskNames { get; }
            = new MvxObservableCollection<string>();

        public override async void ViewAppeared() => await LoadTasksAsync();

        public async Task LoadTasksAsync()
        {
            var tasks = await _taskListService.ShowTaskList();
            TaskNames.AddRange(tasks);
        }




        private readonly TaskListService _taskListService;
    }
}
