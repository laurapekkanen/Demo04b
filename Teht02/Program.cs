using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvistin vahvistin = new Vahvistin();

            do
            {
                Console.WriteLine("Give a new volume value (0-100) > ");
                Console.WriteLine("-> Amplifier volume is set to : " + vahvistin.Volume);
                string line = Console.ReadLine();
                vahvistin.Volume = int.Parse(line);
            } while (vahvistin.Volume != 0);
        }
    }
}
