using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPattern.Refactoring.Builder.Cars;

namespace CreationalDesignPattern.Refactoring.Builder.Components
{
    public class TripComputer
    {
        private Car car;

        public Car SetCar { set => car = value; }

        public void ShowFuelLevel()
        {
            Console.WriteLine("Fuel level: " + car.GetFuel);
        }

        public void ShowStatus()
        {
            if(car.GetEngine.GetStarted)
            {
                Console.WriteLine("Car is started");
            }
            else
            {
                Console.WriteLine("Car isn't started");
            }
        }
    }
}
