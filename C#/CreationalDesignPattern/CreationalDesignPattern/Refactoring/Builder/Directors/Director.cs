using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPattern.Refactoring.Builder.Cars;
using CreationalDesignPattern.Refactoring.Builder.Components;

namespace CreationalDesignPattern.Refactoring.Builder.Directors
{
    public class Director
    {
        public void ContructSportCar(Builders.Builder builder)
        {
            builder.SetCarType(CarType.SPORT_CAR);
            builder.SetSeats(2);
            builder.SetEngine(new Engine(3.0, 0));
            builder.SetTransmission(Tranmission.SEMI_AUTOMATIC);
            builder.SetTripComputer(new TripComputer());
            builder.SetGPSNavigator(new GPSNavigator());
        }

        public void ContructCityCar(Builders.Builder builder)
        {
            builder.SetCarType(CarType.CITY_CAR);
            builder.SetSeats(2);
            builder.SetEngine(new Engine(1.2, 0));
            builder.SetTransmission(Tranmission.AUTOMATIC);
            builder.SetTripComputer(new TripComputer());
            builder.SetGPSNavigator(new GPSNavigator());
        }

        public void ContructSUV(Builders.Builder builder)
        {
            builder.SetCarType(CarType.SUV);
            builder.SetSeats(4);
            builder.SetEngine(new Engine(2.5, 0));
            builder.SetTransmission(Tranmission.MANUAL);
            builder.SetGPSNavigator(new GPSNavigator());
        }
    }
}
