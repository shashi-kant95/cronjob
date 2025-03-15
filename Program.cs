using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        while (true)
        {
            Console.WriteLine("Processing game result...");

            // Generate random result
            string result = new Random().Next(2) == 0 ? "Green" : "Red";
            Console.WriteLine($"Game result: {result}");

            // Wait for 1 minute before running again
            await Task.Delay(TimeSpan.FromMinutes(1));
        }
    }
}
