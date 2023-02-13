using CreationalDesignPattern.Refactoring.Builder.Cars;
using CreationalDesignPattern.Refactoring.Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreationalDesignPattern.Refactoring.Builder.Builders
{
    public class CarBuilder : Builder
    {
        private CarType type;

        private int seats;

        private Engine engine;

        private Tranmission tranmission;

        private TripComputer tripComputer;

        private GPSNavigator gpsNavigator;


        public void SetCarType(CarType type)
        {
            this.type = type;
        }

        public void SetEngine(Engine engine)
        {
            this.engine = engine;
        }

        public void SetGPSNavigator(GPSNavigator gpsNavigator)
        {
            this.gpsNavigator = gpsNavigator;
        }

        public void SetSeats(int seats)
        {
            this.seats = seats;
        }

        public void SetTransmission(Tranmission tranmission)
        {
            this.tranmission = tranmission;
        }

        public void SetTripComputer(TripComputer tripComputer)
        {
            this.tripComputer = tripComputer;
        }

        public Car GetResult()
        {
            return new Car(type, seats, engine, tranmission, tripComputer, gpsNavigator);
        }
    }
}
