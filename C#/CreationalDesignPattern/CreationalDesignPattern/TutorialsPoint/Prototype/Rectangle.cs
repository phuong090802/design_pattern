using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.TutorialsPoint.Prototype
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            type = "Rectangle";
        }

        public override void draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
