using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Refactoring.FactoryMethod
{
    public abstract class Dialog
    {
        public void RenderWindow()
        {
            IButton OkButton = CreateButton();
            OkButton.render();
        }

        public abstract IButton CreateButton();
    }
}
