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
            Recipe recipe = new Recipe();

            bool exit = false;

            while (!exit)
            {
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
            }
        }
    }
}
        
    

