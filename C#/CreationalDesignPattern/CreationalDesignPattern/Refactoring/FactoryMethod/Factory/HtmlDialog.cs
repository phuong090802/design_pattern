using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Refactoring.FactoryMethod
{
    public class HtmlDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new HtmlButton();
        }
    }
}
