using System.Threading.Tasks;


namespace MyMvvmCrossApp1.Core.Services
{
    public class AuthService
    {
        public async Task<bool> Authorize(string username, string password)
        {
            //await Task.Delay(1000);
            if(username == "boris" && password == "123")
            {
                return true;
            }
            else
            {

                return false;
            }
            //Console.WriteLine($"Authorized: {username} & {password}");
        }
    }
}
