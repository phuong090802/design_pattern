using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPattern.Refactoring.Builder.Cars;
using CreationalDesignPattern.Refactoring.Builder.Components;

namespace CreationalDesignPattern.Refactoring.Builder.Cars
{
    public class Car
    {
        private readonly CarType carType;

        private readonly int seats;

        private readonly Engine engine;

        private readonly Tranmission tranmission;

        private readonly TripComputer tripComputer;

        private readonly GPSNavigator gpsNavigator;

        private double fuel = 0;

        public Car(CarType carType, int seats, Engine engine, Tranmission tranmission, TripComputer tripComputer,
            GPSNavigator gpsNavigator)
        {
            this.carType = carType;
            this.seats = seats;
            this.engine = engine;
            this.tranmission = tranmission;
            this.tripComputer = tripComputer;
            if(this.tripComputer != null)
            {
                this.tripComputer.SetCar = this;
            }
            this.gpsNavigator = gpsNavigator;
        }

        public CarType GetCarType { get => carType; }

        public double GetFuel { get => fuel; set => fuel = value; }

        public int GetSeats { get => seats; }

        public Engine GetEngine { get => engine; }

        public Tranmission GetTranmission { get => tranmission; }

        public TripComputer GetTripComputer { get => tripComputer; }

        public GPSNavigator GetGPSNavigator { get => gpsNavigator; }

    }
}
