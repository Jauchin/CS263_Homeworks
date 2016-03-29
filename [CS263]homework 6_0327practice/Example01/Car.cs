using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Car
    {
        private static int totalCars;

        public static int TotalCars
        {
            get { return Car.totalCars; }
            set { Car.totalCars = value; }
        }

        public static int Add(Car car1, Car car2)
        {
            return 1;
        }

        public Car()
        {
            Car.TotalCars++;
        }
    }
}