using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Facebook_Poster
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var facebookClient = new FacebookClient();
            var facebookService = new FacebookService(facebookClient);
            var getAccountTask = facebookService.GetAccountAsync(FacebookSettings.AccessToken);
            Task.WaitAll(getAccountTask);
            var account = getAccountTask.Result;
            Console.WriteLine($"{account.Id} {account.Name}");
            string val;
            Console.Write("Enter file path: ");
                
            var postOnWallTask = facebookService.PostOnWallAsync(FacebookSettings.AccessToken,
            "Hello from C# .NET Core!");
            Task.WaitAll(postOnWallTask);
        }
    }    
}
