using System.Net;

namespace Advent_of_Code
{
    internal class Program
    {
        private const string Url = "https://adventofcode.com/2023/day/1/input";
        static async Task Main(string[] args)
        {
            var cookieContainer = new CookieContainer();
            var baseUri = new Uri(Url); 

            cookieContainer.Add(baseUri, new Cookie("session", "YourSessionToken"));
            
            var handler = new HttpClientHandler
            {
                CookieContainer = cookieContainer
            };

            using (HttpClient client = new HttpClient(handler))
            {
                try
                {
                    var response = await client.GetStringAsync(Url);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }
    }
}