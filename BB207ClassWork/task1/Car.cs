using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207ClassWork.lesson1
{
    class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Millage;

        public Car(string brand, string model, double currentFuel, double fuelFor1Km, double millage)
        {
            Brand = brand;
            Model = model;
            CurrentFuel = currentFuel;
            FuelFor1Km = fuelFor1Km;
            Millage = millage;
        }
        public void Drive(int km)
        {
            double n = km * FuelFor1Km;
            if (n <= CurrentFuel)
            {
                Millage += km;
                CurrentFuel -= km * FuelFor1Km;
            }
            else
            {
                Console.WriteLine("Xeta");
            }

        }
       

    }
}
