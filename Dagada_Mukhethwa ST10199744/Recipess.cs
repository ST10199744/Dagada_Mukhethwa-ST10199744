using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagada_Mukhethwa_ST10199744
{
    internal class Recipess
    {
        private Ingredient[] _ingredients;
        private string[] _steps;
        public Recipess()
        {
            _ingredients = null;
            _steps = null;
        }

        public void EnterIngredients()
        {
            Console.Write("Enter number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());
            _ingredients = new Ingredient[numIngredients];

            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write("Enter ingredient name: ");
                string name = Console.ReadLine();
                Console.Write("Enter quantity: ");
                decimal quantity = decimal.Parse(Console.ReadLine());
                Console.Write("Enter unit of measurement: ");
                string unit = Console.ReadLine();
            }
}
