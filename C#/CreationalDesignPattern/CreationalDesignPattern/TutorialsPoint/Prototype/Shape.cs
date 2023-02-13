using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.TutorialsPoint.Prototype
{
    public abstract class Shape
    {
        private string id;

        protected string type;

        public string Id { get => id; set => id = value; }

        public string Type { get => type; }

        public abstract void draw();

        public Shape()
        {

        }

        public Shape ShallowCopy()
        {
            return MemberwiseClone() as Shape;
        }

    }
}
