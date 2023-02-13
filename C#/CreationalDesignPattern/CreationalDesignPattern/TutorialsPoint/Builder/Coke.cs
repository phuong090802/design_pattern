﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.TutorialsPoint.Builder
{
    public class Coke : ColdDrink
    {
        public override string name()
        {
            return "Coke";
        }

        public override float price()
        {
            return 30.0f;
        }
    }
}
