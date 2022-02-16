using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyMvvmCrossApp1.Core.Services
{
    public class TaskListService
    {
        public async Task<List<string>> ShowTaskList()
        {
            await Task.Delay(1000);
            var taskList = new List<string>()
            {
                "Create app",
                "Do homework",
                "Walk with friends"
            };
            return taskList;
        }
    }
}
