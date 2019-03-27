using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racer.Models
{
    public class SportCar : Car
    {
        public SportCar(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
    }
}
