using System;
using System.Threading.Tasks;

namespace BreakfastExample
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Task<Bacon> baconTask = Bacon.FryBaconAsync(3);
            Bacon bacon = await baconTask;
            Console.WriteLine("bacon is ready");

        }
    }
}
