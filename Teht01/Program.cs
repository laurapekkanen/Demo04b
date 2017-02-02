using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();

            do
            {
                Console.WriteLine("Elevator is now on floor " + hissi.Floor);
                Console.WriteLine("Give floor number (1-5) > ");
                string line = Console.ReadLine();
                hissi.Floor = int.Parse(line);
            } while (hissi.Floor != 0);
        }
    }
}
