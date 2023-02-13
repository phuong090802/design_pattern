using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.TutorialsPoint
{
    public class SingletonPattern
    {
        private static SingletonPattern singletonPattern = new SingletonPattern();

        private SingletonPattern() { }

        public static SingletonPattern GetSinglePattern()
        {
            return singletonPattern;
        }

        public void showMessage()
        {
            Console.WriteLine("Hello Wolrd!");
        }
    }
}
