using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.lesson1
{
    internal class CarMain
    {
        static void Main(string[] args)
        {
            Car car = new Car("bmv", "eee201", 30, 0.17, 250);
            car.Drive(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(car.Millage);
        }
    }
}
