using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Refactoring.Prototype
{
    public class BundleShapeCache
    {
        private Dictionary<string, Shape> cache = new Dictionary<string, Shape>();

        public BundleShapeCache()
        {
            Circle circle = new Circle();
            circle.x = 5;
            circle.y = 7;
            circle.radius = 45;
            circle.color = "Green";

            Rectangle rectangle = new Rectangle();
            rectangle.x = 6;
            rectangle.y = 9;
            rectangle.width = 8;
            rectangle.height = 10;
            rectangle.color = "Blue";
            cache.Add("Big green circle", circle);
            cache.Add("Medium blue rectangle", rectangle);

        }

        public Shape Put(string key, Shape shape)
        {
            cache.Add(key, shape);
            return shape;
        }

        public Shape Get(string key)
        {
            return cache[key].clone();
        }
    }
}
