using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.TutorialsPoint.AbstractFactory
{
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Square::draw method().");
        }
    }
}
