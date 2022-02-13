using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyMvvmCrossApp1.Core.Services
{
    public class AuthService
    {
        public async Task<bool> Authorize(string username, string password)
        {
            await Task.Delay(1000);
            Console.WriteLine($"Authorized: {username} & {password}");
            return true;
        }
    }
}
