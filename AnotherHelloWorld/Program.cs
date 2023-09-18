using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace AnotherHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int health = 100;
            int lives = 3;
            int pointsgained;
            int healthlost;

            Console.WriteLine("Hud v1");
            

            Console.WriteLine();
            Console.WriteLine("Press any key ");
            Console.ReadKey(true);
            Console.WriteLine();

            Console.WriteLine("=====================");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("=====================");

            Console.ReadKey(true);
            Console.WriteLine();

            
            pointsgained = 250;
            healthlost = 20;

            score = score + pointsgained;
            health = health - healthlost;

            Console.WriteLine("=====================");

            Console.WriteLine("In Battle the ");
            Console.WriteLine("player gained " + pointsgained + " points.");
            
            Console.WriteLine("In Battle the ");
            Console.WriteLine("player lost " + healthlost + " health.");

            Console.WriteLine("=====================");

            Console.ReadKey(true);
            Console.WriteLine();

            Console.WriteLine("=====================");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("=====================");



            Console.ReadKey();
        }
    }
}
