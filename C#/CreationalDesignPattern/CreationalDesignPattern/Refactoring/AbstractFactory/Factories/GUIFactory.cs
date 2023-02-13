using CreationalDesignPattern.Refactoring.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Refactoring
{
    public interface GUIFactory
    {
        AbstractFactory.IButton CreateButton();
        Checkbox CreateCheckbox();
    }
}
