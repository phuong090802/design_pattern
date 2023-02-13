using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.TutorialsPoint.AbstractFactory
{
    public class ShapeFactory : AbstractFactory
    {
        public override Shape GetShape(string TypeShape)
        {
            if (TypeShape.Equals("RECTANGLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Rectangle();
            }
            if(TypeShape.Equals("SQUARE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Square();
            }
            return null;
        }
    }
}
