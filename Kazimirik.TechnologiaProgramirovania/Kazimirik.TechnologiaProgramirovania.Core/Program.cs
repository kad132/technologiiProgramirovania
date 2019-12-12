using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kazimirik.TechnologiaProgramirovania.Classes;

namespace Kazimirik.TechnologiaProgramirovania.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Client> queue = new Queue<Client>();
            Console.WriteLine("Введите количество тиков");
            var tick = Convert.ToInt32(Console.ReadLine());
            for (var currentTick = 0; currentTick < tick; currentTick++)
            {
                if (Generator.NewClient(currentTick))
                {
                    queue.Enqueue(new Client()); 
                }
                
                
            }

        }
    }
}
