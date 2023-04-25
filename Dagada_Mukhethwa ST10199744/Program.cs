using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagada_Mukhethwa_ST10199744
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recipess recipe = new Recipess();

            bool exit = false;

            while (!exit)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Welcome to the recipe application");
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Enter ingredients");
                Console.WriteLine("2. Enter steps");
                Console.WriteLine("3. Display recipe");
                Console.WriteLine("4. Scale recipe");
                Console.WriteLine("5. Reset recipe");
                Console.WriteLine("6. Clear recipe");
                Console.WriteLine("7. Exit");

                Console.Write("\nEnter choice: ");
                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        recipe.EnterIngredientss();
                        break;
                    case 2:
                        recipe.EnterSteps();
                        break;
                    case 3:
                        recipe.DisplayRecipess();
                        break;
                    case 4:

                        Console.Write("Enter scale factor: ");
                        decimal factor = decimal.Parse(Console.ReadLine());
                        recipe.ScaleRecipess(factor);
                        break;
                    case 5:
                        recipe.ResetRecipess();
                        break;
                    case 6:
                        recipe.ClearRecipess();
                        break;

                }
            }
        }
    }
}
   

        
    

