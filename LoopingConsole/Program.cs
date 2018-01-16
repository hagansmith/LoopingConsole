using System;
using System.Collections.Generic;

namespace LoopingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = new List<Child>
            {
                new Child { Name = "Sally", Sick = true },
                new Child { Name = "Ralph", Sick = false }
            };

            foreach (var child in children )
            {
                Console.WriteLine(child.ForgeASickNote());
                Console.WriteLine($"{child.Name} is {(child.Sick ? "sick" : "not sick")}");
            }

            Console.ReadLine();
          
        }
    }
}
