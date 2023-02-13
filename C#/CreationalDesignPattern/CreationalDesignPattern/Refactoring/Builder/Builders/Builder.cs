using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPattern.Refactoring.Builder.Cars;
using CreationalDesignPattern.Refactoring.Builder.Components;

namespace CreationalDesignPattern.Refactoring.Builder.Builders
{
    public interface Builder
    {
        void SetCarType(CarType type);

        void SetSeats(int seats);

        void SetEngine(Engine engine);

        void SetTransmission(Tranmission tranmission);

        void SetTripComputer(TripComputer tripComputer);

        void SetGPSNavigator(GPSNavigator gpsNavigator);
    }
}
