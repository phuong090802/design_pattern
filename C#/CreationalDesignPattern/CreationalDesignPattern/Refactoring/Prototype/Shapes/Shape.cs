using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Refactoring.Prototype
{
    public abstract class Shape
    {
        public int x;

        public int y;

        public string color;

        public Shape()
        {

        }

        public Shape(Shape target)
        {
            if (target != null)
            {
                x = target.x;
                y = target.y;
                color = target.color;
            }
        }

        public abstract Shape clone();

        public override bool Equals(object object2)
        {
            Shape shape2 = object2 as Shape;
            if (!(shape2 != null))
            {
                return false;
            }
            return shape2.x == x && shape2.y == y && Equals(shape2.color, color);
        }

        public override int GetHashCode()
        {

            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"x = {x}, y = {y}, color = {color}";
        }
    }
}
