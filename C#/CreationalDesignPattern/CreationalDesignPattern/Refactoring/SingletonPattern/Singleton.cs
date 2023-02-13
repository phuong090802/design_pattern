using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CreationalDesignPattern.Refactoring
{
    class Singleton
    {
        private static Singleton instance;

        public string value;

        private Singleton(string value)
        {
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            this.value = value;
        }

        public static Singleton GetIntance(string value)
        {
            if (instance == null)
            {
                instance = new Singleton(value);
            }
            return instance;
        }
    }
}
