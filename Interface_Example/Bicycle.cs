using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    public class Bicycle : Vehicle
    {
        int speed;

        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }

        public void CheckSpeed()
        {
            Console.WriteLine("Speed : " + speed);
        }
    }
}
