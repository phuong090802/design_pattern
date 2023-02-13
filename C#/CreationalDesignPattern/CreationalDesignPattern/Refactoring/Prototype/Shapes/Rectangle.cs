using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Refactoring.Prototype
{
    public class Rectangle : Shape
    {
        public int width;

        public int height;

        public Rectangle()
        {

        }

        public Rectangle(Rectangle target) : base(target)
        {
            if (target != null)
            {
                width = target.width;
                height = target.height;
            }
        }

        public override Shape clone()
        {
            return new Rectangle(this);
        }

        public override bool Equals(object object2)
        {
            Rectangle shape2 = object2 as Rectangle;
            if (!(shape2 != null) || !base.Equals(object2))
            {
                return false;
            }
            return shape2.width == width && shape2.height == height;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString() 
        {
            
            return base.ToString() +  $", width = {width}, height = {height}";
        }
    }
}
