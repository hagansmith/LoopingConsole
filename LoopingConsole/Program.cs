using System;

namespace LoopingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a child with name of sally that is sick
            var sally = new Child { Name = "Sally", Sick = true };
            Console.WriteLine(sally.ForgeASickNote());
            Console.WriteLine ($"{sally.Name} is {(sally.Sick ? "sick" : "not sick")}");

            // create a second child with name of sally that is sick
            var ralph = new Child { Name = "Ralph", Sick = false };
            Console.WriteLine(ralph.ForgeASickNote());
            Console.WriteLine($"{ralph.Name} is {(ralph.Sick ? "sick" : "not sick")}");

            Console.ReadLine();
        }
    }
}
