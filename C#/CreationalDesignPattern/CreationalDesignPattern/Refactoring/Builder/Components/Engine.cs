using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Refactoring.Builder.Components
{
    public class Engine
    {
        private readonly double volume;

        private double mileage;

        private bool started;

        public Engine(double volume, double mileage)
        {
            this.volume = volume;
            this.mileage = mileage;
        }

        public void On()
        {
            started = true;
        }

        public void Off()
        {
            started = false;
        }

        public bool GetStarted { get => started; }

        public void Go(double mileage)
        {
            if(started)
            {
                this.mileage += mileage;
            }
            else
            {
                Console.WriteLine("Cannot go(), you must start engine first!");
            }
        }

        public double GetVolume { get => volume; }

        public double GetMileage { get => mileage; }

    }
}
