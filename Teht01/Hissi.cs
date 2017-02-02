using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Hissi
    {
        private readonly int minFloor = 1;
        private readonly int maxFloor = 5;

        private int floor = 1;

        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value >= minFloor && value <= maxFloor) floor = value;
                else
                {
                    Console.WriteLine("Wrong floor, choose another.");
                }
            }
        }
    }
}
