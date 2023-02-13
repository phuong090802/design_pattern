package com.ute.refactoring.builder.builders;

import com.ute.refactoring.builder.cars.CarType;
import com.ute.refactoring.builder.components.Engine;
import com.ute.refactoring.builder.components.GPSNavigator;
import com.ute.refactoring.builder.components.Transmission;
import com.ute.refactoring.builder.components.TripComputer;

public interface Builder {
    void setCarType(CarType type);
    void setSeats(int seats);

    void setEngine(Engine engine);
    void setTransmission(Transmission transmission);
    void setTripComputer(TripComputer tripComputer);
    void setGPSNavigator(GPSNavigator gpsNavigator);
}
