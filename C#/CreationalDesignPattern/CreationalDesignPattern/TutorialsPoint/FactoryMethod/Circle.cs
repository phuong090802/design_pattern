using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.TutorialsPoint.FactoryPattern
{
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle draw() method.");
        }
    }
}
