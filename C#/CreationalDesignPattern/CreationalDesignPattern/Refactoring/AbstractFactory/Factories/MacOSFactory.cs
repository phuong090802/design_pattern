using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Refactoring.AbstractFactory
{
    public class MacOSFactory : GUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public Checkbox CreateCheckbox()
        {
            return new MacOSCheckbox();
        }
    }
}
