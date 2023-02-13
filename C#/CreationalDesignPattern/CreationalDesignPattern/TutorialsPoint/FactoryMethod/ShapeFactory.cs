using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.TutorialsPoint.FactoryPattern
{
    public class ShapeFactory
    {
        public Shape GetShape(string ShapeType)
        {
            if(ShapeType == null) 
            {
                return null;
            }
            if(ShapeType.Equals("CIRCLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Circle();
            }
            if(ShapeType.Equals("RECTANGLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Rectangle();
            }
            if(ShapeType.Equals("SQUARE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Square();
            }
            return null;
        }
    }
}
