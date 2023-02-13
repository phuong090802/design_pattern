using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern.TutorialsPoint.Builder
{
    public class Meal
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;
            foreach (Item item in items)
            {
                cost += item.price();
            }
            return cost;
        }

        public void ShowItems()
        {
            foreach (Item item in items)
            {
                Console.Write("Item : " + item.name());
                Console.Write(" , Packing : " + item.packing().pack());
                Console.WriteLine(" , Price : " + item.price());
            }
        }
    }
}
