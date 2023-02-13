using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.TutorialsPoint.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract Shape GetShape(string TypeShape);
    }
}
