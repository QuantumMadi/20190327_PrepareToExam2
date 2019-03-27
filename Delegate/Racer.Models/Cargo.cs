using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racer.Models
{
    public class Cargo : Car
    {
        public int Loading{ get; set; }

        public Cargo( int speed, int load, string model)
        {
            Speed = speed - (speed*(load/100));
            Model = model;
            Loading = load;
        }
    }
}
