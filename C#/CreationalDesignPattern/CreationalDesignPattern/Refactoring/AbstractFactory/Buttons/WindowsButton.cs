using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Refactoring.AbstractFactory
{
    public class WindowsButton : IButton
    {
        public void paint()
        {
            Console.WriteLine("You have created WindowButton.");
        }
    }
}
