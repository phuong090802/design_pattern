using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CreationalDesignPattern.TutorialsPoint.Prototype
{
    public class ShapeCache
    {
        private static Dictionary<string, Shape> shapeDistionary = new Dictionary<string, Shape>();

        public static Shape GetShape(string shapeId)
        {
            Shape cachedShape = shapeDistionary[shapeId];
            return cachedShape.ShallowCopy();
        }

        public static void loadCache()
        {
            Circle circle = new Circle();
            circle.Id = "1";
            shapeDistionary.Add(circle.Id, circle);

            Square square = new Square();
            square.Id = "2";
            shapeDistionary.Add(square.Id, square);

            Rectangle rectangle = new Rectangle();
            rectangle.Id = "3";
            shapeDistionary.Add(rectangle.Id, rectangle);
        }
    }
}
