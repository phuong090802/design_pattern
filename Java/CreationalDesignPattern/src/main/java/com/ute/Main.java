package com.ute;

import com.ute.refactoring.abstractfactory.app.Application;
import com.ute.refactoring.abstractfactory.factories.GUIFactory;
import com.ute.refactoring.abstractfactory.factories.MacOSFactory;
import com.ute.refactoring.abstractfactory.factories.WindowsFactory;
import com.ute.refactoring.factorymethod.factory.Dialog;
import com.ute.refactoring.factorymethod.factory.HtmlDialog;
import com.ute.refactoring.factorymethod.factory.WindowsDialog;

public class Main {
    private static Dialog dialog;

    private static Application configureApplication() {
        Application app;
        GUIFactory factory;
        String osName = System.getProperty("os.name").toLowerCase();
        if (osName.contains("mac")) {
            factory = new MacOSFactory();
        } else {
            factory = new WindowsFactory();
        }
        app = new Application(factory);
        return app;
    }

    public static void main(String[] args) {
//        region Singleton Pattern
//        region Tutorialspoint
//        SingletonPattern singletonPattern = SingletonPattern.getSinglePattern();
//        singletonPattern.showMessage();
//        endregion
//
//        region Refactoring
//        Singleton singleton = Singleton.getInstance("FOO");
//        System.out.println(singleton.value);
//
//        Singleton anotherSingleton = Singleton.getInstance("BAR");
//        System.out.println(anotherSingleton.value);
//        endregion
//endregion

//        region Factory Method
//        region Tutorialspoint
//        com.ute.tutorialspoint.factorymethod.ShapeFactory shapeFactory = new com.ute.tutorialspoint.factorymethod.ShapeFactory();
//        com.ute.tutorialspoint.factorymethod.Shape shape1 = shapeFactory.getShape("CIRCLE");
//        shape1.draw();
//
//        com.ute.tutorialspoint.factorymethod.Shape shape2 = shapeFactory.getShape("RECTANGLE");
//        shape2.draw();
//
//        com.ute.tutorialspoint.factorymethod.Shape shape3 = shapeFactory.getShape("SQUARE");
//        shape3.draw();
//        endregion
//    region Refactoring
//        configure();
//        runBusinessLogin();
//        endregion
//        endregion

//        region Abstract Factory
//        region Tutorialspoint
//        AbstractFactory shapeFactory = FactoryProducer.getFactory(false);
//        com.ute.tutorialspoint.abstractfactory.Shape shape1 = shapeFactory.getShape("RECTANGLE");
//        shape1.draw();
//        com.ute.tutorialspoint.abstractfactory.Shape shape2 = shapeFactory.getShape("SQUARE");
//        shape2.draw();
//        AbstractFactory shapeFactory1 = FactoryProducer.getFactory(true);
//        com.ute.tutorialspoint.abstractfactory.Shape shape3 = shapeFactory1.getShape("RECTANGLE");
//        shape3.draw();;
//        com.ute.tutorialspoint.abstractfactory.Shape shape4 = shapeFactory.getShape("SQUARE");
//        shape4.draw();
//        endregion

//        region Refactoring
//        Application app = configureApplication();
//        app.paint();
//        endregion
//        endregion

//        region Prototype
//        region Tutorialspoint
//        ShapeCache.loadCache();
//        com.ute.tutorialspoint.prototype.Shape clonedShape = ShapeCache.getShape("1");
//        System.out.println("Shape : " + clonedShape.getType());
//
//        com.ute.tutorialspoint.prototype.Shape clonedShape2 = ShapeCache.getShape("2");
//        System.out.println("Shape : " + clonedShape2.getType());
//
//        com.ute.tutorialspoint.prototype.Shape clonedShape3 = ShapeCache.getShape("3");
//        System.out.println("Shape : " + clonedShape3.getType());
//        endregion

//    region Refactoring
//        com.ute.refactoring.prototype.cache.BundledShapeCache cache = new com.ute.refactoring.prototype.cache.BundledShapeCache();
//        com.ute.refactoring.prototype.shapes.Shape shape1 = cache.get("Big green circle");
//        com.ute.refactoring.prototype.shapes.Shape shape2 = cache.get("Medium blue rectangle");
//        com.ute.refactoring.prototype.shapes.Shape shape3 = cache.get("Medium blue rectangle");
//        if (shape1 != shape2 && !shape1.equals(shape2)) {
//            System.out.println("Big green circle != Medium blue rectangle (yay!)");
//        } else {
//            System.out.println("Big green circle == Medium blue rectangle (booo!)");
//        }
//        if(shape2 != shape3) {
//            System.out.println("Medium blue rectangles are two different object (yay!)");
//            if(shape2.equals(shape3)) {
//                System.out.println("And they are identical (yay!)");
//            }
//            else {
//                System.out.println("But they are not identical (booo!)");
//            }
//        } else {
//            System.out.println("Rectangle object are the same (booo!)");
//        }
//        endregion
//        endregion

//        region Builder
//        region Tutorialspoint
//        MealBuilder mealBuilder = new MealBuilder();
//        Meal vegMeal = mealBuilder.prepareVegMeal();
//        System.out.println("Veg Meal");
//        vegMeal.showItems();
//        System.out.println("Total Cost: " + vegMeal.getCost());
//
//        Meal nonVegMeal = mealBuilder.prepareNonVegMeal();
//        System.out.println("\n\nNone-Veg Meal");
//        nonVegMeal.showItems();
//        System.out.println("Total Cost: " + nonVegMeal.getCost());
//          endregion
//        region Refactoring
//        Director director = new Director();
//        CarBuilder builder = new CarBuilder();
//        director.constructSportCart(builder);
//        Car car = builder.getResult();
//        System.out.println("Car builder:\n"  + car.getCarType());
//
//        CarManualBuilder manualBuilder = new CarManualBuilder();
//        director.constructSportCart(manualBuilder);
//        Manual carManual = manualBuilder.getResult();
//        System.out.println("\nCar manual built:\n" + carManual.print());
// endregion
// endregion

    }

    static void configure() {
        if (System.getProperty("os.name").equals("Windows 11")) {
            dialog = new WindowsDialog();
        } else {
            dialog = new HtmlDialog();
        }
    }

    static void runBusinessLogin() {
        dialog.renderWindows();
    }
}
