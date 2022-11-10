using System;
using System.Threading.Tasks;

namespace BreakfastExample
{
    public class Bacon
    {
        public int slices { get; set; }

        public static async Task<Bacon> FryBaconAsync(int slices)
        {
            Bacon b = new();
            b.slices = slices;
            int delayTime = 1000 * slices;

            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(delayTime);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(delayTime);
            Console.WriteLine("Put bacon on plate");

            return b;
        }
    }
    public class Coffee { }
    public class Egg { }
    public class Juice { }
    public class Toast { }
}