using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.TutorialsPoint.AbstractFactory
{
    public class RoundedSquare : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside RoundedSquare::draw() method.");
        }
    }
}
