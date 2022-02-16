using System.Threading.Tasks;

namespace MyMvvmCrossApp1.Core.Services
{
    public class TaskListService
    {
        public async Task<bool> ShowTaskList(/*args*/)
        {
            await Task.Delay(1000);
            //выдать результат - список простейший задач
            return true;
        }
    }
}
