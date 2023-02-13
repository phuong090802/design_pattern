using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Refactoring.Prototype
{
    public class Circle : Shape
    {
        public int radius;

        public Circle()
        {

        }

        public Circle(Circle target) : base(target)
        {
            if (target != null)
            {
                radius = target.radius;
            }
        }

        public override Shape clone()
        {
            return new Circle(this);
        }

        public override bool Equals(object object2)
        {
            Circle shape2 = object2 as Circle;
            if (!(shape2 != null) || !base.Equals(object2))
            {
                return false;
            }
            return radius == shape2.radius;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString() + $", radius = {radius}";
        }
    }
}
