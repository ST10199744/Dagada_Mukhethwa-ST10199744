using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagada_Mukhethwa_ST10199744
{
    internal class Recipess
    {
        private Ingredientss[] _ingredients;
        private string[] _steps;
        public Recipess()
        {
            _ingredients = null;
            _steps = null;
        }

        public void EnterIngredientss()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("Enter number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());
            _ingredients = new Ingredientss[numIngredients];

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
        public void EnterSteps()
        {
            Console.Write("Enter number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());
            _steps = new string[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Enter step {i + 1}: ");
                _steps[i] = Console.ReadLine();

            }
        }

        public void DisplayRecipess()
        {
            Console.WriteLine("\nRecipe:");

            if (_ingredients != null)
            {
                Console.WriteLine("Ingredientss:");
                foreach (Ingredientss ingredient in _ingredients)
                {
                    Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} {ingredient.Name}");
                }
            }

            if (_steps != null)
            {
                Console.WriteLine("\nSteps:");
                for (int i = 0; i < _steps.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {_steps[i]}");
                }
            }
        }

        public void ScaleRecipess(decimal factor)
        {
            if (_ingredients != null)
            {
                foreach (Ingredientss ingredient in _ingredients)
                {
                    ingredient.Quantity *= factor;
                }

            }
        }


        public void ResetRecipess()
        {
            if (_ingredients != null)
            {
                foreach (Ingredientss ingredient in _ingredients)
                {
                    ingredient.Quantity /= 2;
                }

            }
        }
        public void ClearRecipess()
        {
            _ingredients = null;
            _steps = null;
        }
    }
}



