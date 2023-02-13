using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.Refactoring.Builder.Components
{
    public class GPSNavigator
    {
        private string route;

        public GPSNavigator()
        {
            route = "221b, Baker Street, London to Scotland Yard, 8 - 10 Broadway, London";
        }

        public GPSNavigator(string manualRoute)
        {
            route = manualRoute;
        }

        public string GetRoute { get => route; }
    }
}
