using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPattern.Refactoring.Builder.Cars;
using CreationalDesignPattern.Refactoring.Builder.Components;

namespace CreationalDesignPattern.Refactoring.Builder.Cars
{
    public class Manual
    {
        private readonly CarType carType;

        private readonly int seats;

        private readonly Engine engine;

        private readonly Tranmission tranmission;

        private readonly TripComputer tripComputer;

        private readonly GPSNavigator gpsNavigator;

        public Manual(CarType carType, int seats, Engine engine, Tranmission tranmission, TripComputer tripComputer,
            GPSNavigator gpsNavigator)
        {
            this.carType = carType;
            this.seats = seats;
            this.engine = engine;
            this.tranmission = tranmission;
            this.tripComputer = tripComputer;
            this.gpsNavigator = gpsNavigator;
        }

        public string Print()
        {
            string info = "";
            info += "Type of car: " + carType + "\n";
            info += "Count of seats: " + seats + "\n";
            info += "Engine: volume - " + engine.GetVolume + "; mileage - " + engine.GetMileage + "\n";
            info += "Tranmission: " + tranmission + "\n";
            if(this.tripComputer != null)
            {
                info += "Trip Computer: Functional" + "\n";
            }
            else
            {
                info += "Trip Computer: N/A" + "\n";
            }
            if(this.gpsNavigator != null)
            {
                info += "GPS Navigator: Functional" + "\n";
            }
            else
            {
                info += "GPS Navigator: N/A" + "\n";
            }
            return info;
        }
    }
}
