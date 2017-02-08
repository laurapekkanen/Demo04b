using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Vahvistin
    {
        private readonly int minVolume = 0;
        private readonly int maxVolume = 100;

        public int volume = 1;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= minVolume && value <= maxVolume) volume = value;
                else
                {
                    Console.WriteLine("Not valid volume. Try again.");
                }
            }
        }
    }
}
