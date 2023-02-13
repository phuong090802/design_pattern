using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Refactoring.AbstractFactory
{
    public class Application
    {
        private IButton button;
        private Checkbox checkbox;

        public Application(GUIFactory factory)
        {
            button = factory.CreateButton();
            checkbox = factory.CreateCheckbox();
        }

        public void paint()
        {
            button.paint();
            checkbox.paint();
        }
    }
}
