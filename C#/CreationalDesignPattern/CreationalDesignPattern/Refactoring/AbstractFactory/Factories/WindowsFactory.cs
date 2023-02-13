using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Refactoring.AbstractFactory
{
    public class WindowsFactory : GUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public Checkbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
