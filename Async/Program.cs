using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Async
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExampleAsync().GetAwaiter();
            ExampleAsync().Wait();
            //ExampleAsync();
            ExampleAsyncAppend().Wait();

            string text = "A class is the most powerful data type. Like a structure, " +
                "a class defines the data and behavior of the data type.";
            File.WriteAllText(@"C:\junk\test.txt", text);

            WebClient webClient = new WebClient();
            string reply = webClient.DownloadString("https://bol.rwbaird.com/");
            //Console.WriteLine(reply);
            File.WriteAllText(@"C:\junk\bol.txt", reply);
            Console.ReadLine();
        }


        private static async Task ExampleAsync()
        {
            string[] lines = { "First line", "Second line", "Third line" };
            using StreamWriter file = new(@"C:\junk\WriteLines2.txt");

            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    Console.WriteLine(line);
                    await file.WriteLineAsync(line);
                }
            }
        }

        private static async Task ExampleAsyncAppend()
        {
            using StreamWriter file = new(@"C:\junk\WriteLines2.txt", append: true);
            await file.WriteLineAsync("Fourth line");
        }

    }
}
