using System;
using System.Threading.Tasks;

namespace BreakfastExample
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Bacon bacon = await Bacon.FryBaconAsync(3);
            Console.WriteLine("bacon is ready");

        }
    }
}
