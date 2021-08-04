using System;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var counter = 0;
            while (counter < 5)
            {
                Console.WriteLine($"Counter: {++counter}");
                await Task.Delay(500);
            }
        }
    }
}
