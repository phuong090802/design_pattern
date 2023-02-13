using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreationalDesignPattern.TutorialsPoint.FactoryPattern;
using CreationalDesignPattern.Refactoring;
using CreationalDesignPattern.TutorialsPoint;
using CreationalDesignPattern.Refactoring.FactoryMethod;
using CreationalDesignPattern.Refactoring.Builder;
using CreationalDesignPattern.TutorialsPoint.AbstractFactory;
using CreationalDesignPattern.Refactoring.Prototype;
using CreationalDesignPattern.TutorialsPoint.Prototype;
using CreationalDesignPattern.TutorialsPoint.Builder;
using CreationalDesignPattern.Refactoring.Builder.Directors;
using CreationalDesignPattern.Refactoring.Builder.Builders;
using CreationalDesignPattern.Refactoring.Builder.Cars;

namespace CreationalDesignPattern
{
    class Program
    {
        private static Dialog dialog;

        private static Refactoring.AbstractFactory.Application ConfigureApplication()
        {
            Refactoring.AbstractFactory.Application app;
            GUIFactory factory;
            string osName = System.Environment.OSVersion.VersionString;
            if (osName.Contains("Windows"))
            {
                factory = new Refactoring.AbstractFactory.WindowsFactory();
            }
            else
            {
                factory = new Refactoring.AbstractFactory.MacOSFactory();
            }
            app = new Refactoring.AbstractFactory.Application(factory);
            return app;
        }

        static void Main(string[] args)
        {

            #region Singleton Pattern
            #region Tutorialspoint
            //SingletonPattern singlePattern = SingletonPattern.GetSinglePattern();
            //singlePattern.showMessage(); 
            #endregion

            #region Refactoring
            //Singleton singleton = Singleton.GetIntance("FOO");
            //Console.WriteLine(singleton.value);

            //Singleton anotherSingleton = Singleton.GetIntance("BAR");
            //Console.WriteLine(anotherSingleton.value); 
            #endregion
            #endregion

            #region Factory Method
            #region Tutorialspoint
            //ShapeFactory shapeFactory = new ShapeFactory();

            //Shape shape1 = shapeFactory.GetShape("CIRCLE");
            //shape1.draw();

            //Shape shape2 = shapeFactory.GetShape("RECTANGLE");
            //shape2.draw();

            //Shape shape3 = shapeFactory.GetShape("SQUARE");
            //shape3.draw();  
            #endregion

            #region Refactoring
            //Configuare();
            //RunBusinessLogin(); 
            #endregion
            #endregion

            #region Abstract Fatory
            #region Tutorialspoint
            //AbstractFactory shapeFactory = FactoryProducer.GetFactory(false);
            //TutorialsPoint.AbstractFactory.Shape shape1 = shapeFactory.GetShape("RECTANGLE");
            //shape1.draw();
            //TutorialsPoint.AbstractFactory.Shape shape2 = shapeFactory.GetShape("SQUARE");
            //shape2.draw();

            //AbstractFactory shapeFactory1 = FactoryProducer.GetFactory(true);
            //TutorialsPoint.AbstractFactory.Shape shape3 = shapeFactory.GetShape("RECTANGLE");
            //shape1.draw();
            //TutorialsPoint.AbstractFactory.Shape shape4 = shapeFactory.GetShape("SQUARE");
            //shape2.draw();  
            #endregion

            #region Refactoring
            //Refactoring.AbstractFactory.Application app = ConfigureApplication();
            //app.paint(); 
            #endregion
            #endregion

            #region Prototype
            #region Tutorialspoint
            //ShapeCache.loadCache();

            //TutorialsPoint.Prototype.Shape clonedShape = ShapeCache.GetShape("1");
            //Console.WriteLine("Shape : " + clonedShape.Type);

            //TutorialsPoint.Prototype.Shape clonedShape2 = ShapeCache.GetShape("2");
            //Console.WriteLine("Shape : " + clonedShape2.Type);

            //TutorialsPoint.Prototype.Shape clonedShape3 = ShapeCache.GetShape("3");
            //Console.WriteLine("Shape : " + clonedShape3.Type); 
            #endregion

            #region Refactoring
            #region Demo
            //List<Refactoring.Prototype.Shape> shapes = new List<Refactoring.Prototype.Shape>();
            //List<Refactoring.Prototype.Shape> shapesCopy = new List<Refactoring.Prototype.Shape>();
            //Refactoring.Prototype.Circle circle = new Refactoring.Prototype.Circle();
            //circle.x = 10;
            //circle.y = 20;
            //circle.radius = 15;
            //circle.color = "red";
            //shapes.Add(circle);

            //Refactoring.Prototype.Circle anotherCircle = circle.clone() as Refactoring.Prototype.Circle;
            //shapes.Add(anotherCircle);

            //Refactoring.Prototype.Rectangle rectangle = new Refactoring.Prototype.Rectangle();
            //rectangle.width = 10;
            //rectangle.height = 20;
            //rectangle.color = "blue";
            //shapes.Add(rectangle);

            //cloneAndCompare(shapes, shapesCopy);  
            #endregion
            #endregion

            //BundleShapeCache cache = new BundleShapeCache();
            //Refactoring.Prototype.Shape shape1 = cache.Get("Big green circle");
            //Refactoring.Prototype.Shape shape2 = cache.Get("Medium blue rectangle");
            //Refactoring.Prototype.Shape shape3 = cache.Get("Medium blue rectangle");

            //if (shape1 != shape2 && !shape1.Equals(shape2))
            //{
            //    Console.WriteLine("Big green circle != Medium blue rectangle (yay!)");
            //}
            //else
            //{
            //    Console.WriteLine("Big green circle == Medium blue rectangle (booo!)");
            //}
            //if (shape2 != shape3)
            //{
            //    Console.WriteLine("Medium blue rectangles are two different object (yay!)");
            //    if (shape2.Equals(shape3))
            //    {
            //        Console.WriteLine("And they are identical (yay!)");
            //    }
            //    else
            //    {
            //        Console.WriteLine("But they are not identical (booo!)");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Rectangle objects are the same (booo!)");
            //} 
            #endregion

            #region Builder
            #region Tutorialspoint
            //MealBuider mealBuider = new MealBuider();
            //Meal vegMeal = mealBuider.PrepareVegMeal();
            //Console.WriteLine("Veg Meal");
            //vegMeal.ShowItems();
            //Console.WriteLine("Total Cost : " + vegMeal.GetCost());

            //Meal nonVegMeil = mealBuider.PrepareNonVegMeal();
            //Console.WriteLine("\n\nNon-Veg Meal");
            //nonVegMeil.ShowItems();
            //Console.WriteLine("Total Cost : " + nonVegMeil.GetCost()); 
            #endregion

            #region Refactoring
            //Director director = new Director();
            //CarBuilder bulder = new CarBuilder();
            //director.ContructSportCar(bulder);

            //Car car = bulder.GetResult();
            //Console.WriteLine("Car built:\n" + car.GetCarType);

            //CarManualBuidler manualBuidler = new CarManualBuidler();
            //director.ContructSportCar(manualBuidler);
            //Manual carManual = manualBuidler.GetResult();
            //Console.WriteLine("\nCar manual built:\n" + carManual.Print()); 
            #endregion
            #endregion

        }

        private static void cloneAndCompare(List<Refactoring.Prototype.Shape> shapes, List<Refactoring.Prototype.Shape> shapesCopy)
        {
            foreach (Refactoring.Prototype.Shape shape in shapes)
            {
                shapesCopy.Add(shape.clone());
            }

            for (int i = 0; i < shapesCopy.Count; i++)
            {
                //Console.WriteLine(shapes.ElementAt(i).ToString());
                //Console.WriteLine(shapesCopy.ElementAt(i).ToString());
                if (shapes.ElementAt(i) != shapesCopy.ElementAt(i))
                {
                    Console.WriteLine(i + " : Shapes are different objects (yay!)");
                    if (shapes.ElementAt(i).Equals(shapesCopy.ElementAt(i)))
                    {
                        Console.WriteLine(i + " : And they are identical (yay!)");
                    }
                    else
                    {
                        Console.WriteLine(i + " : But they are not identical (booo!)");
                    }
                }
                else
                {
                    Console.WriteLine(i + " : Shape objects are the same (booo!)");
                }
            }
        }

        static void Configuare()
        {
            if (Environment.OSVersion.VersionString.Contains("Windows"))
            {
                dialog = new WindowsDialog();
            }
            else
            {
                dialog = new HtmlDialog();
            }
        }

        static void RunBusinessLogin()
        {
            dialog.RenderWindow();
        }
    }
}
