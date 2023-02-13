using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.TutorialsPoint.AbstractFactory
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override Shape GetShape(string TypeShape)
        {
            if(TypeShape.Equals("RECTANGLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new RoundedRectangle();
            }
            if(TypeShape.Equals("SQUARE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new RoundedSquare();
            }
            return null;
        }
    }
}
