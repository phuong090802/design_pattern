using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.TutorialsPoint.AbstractFactory
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(bool rounded)
        {
            if (rounded)
            {
                return new RoundedShapeFactory();
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }
}
