using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratcie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me your name... ");
            string myName = Console.ReadLine();
            Console.WriteLine("your name is..." + myName);

            while (true)
            {

                Console.WriteLine("What sort of maths problems will we be doing today.. " +
                    "Mutliply divide subtract or takeaway? " +
                    "(X , / , - , + ) ");

                string operation = Console.ReadLine();
                Console.WriteLine("What two numbers would you like to " + operation + " with...");
                Console.WriteLine("Number 1: ");

                float num1 = (float)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Number 2: ");
                float num2 = (float)Convert.ToDouble(Console.ReadLine());

                if (operation == "x")
                {
                    Console.WriteLine(num1 * num2);
                    string answerMultiply = Console.ReadLine();
                }
                if (operation == "/")
                {
                    Console.WriteLine(num1 / num2);
                    string answerDivide = Console.ReadLine();
                }
                if (operation == "-")
                {
                    Console.WriteLine(num1 - num2);
                    string answerMinus = Console.ReadLine();
                }
                if (operation == "+")
                {
                    Console.WriteLine(num1 + num2);
                    string answerAddition = Console.ReadLine();
                }
                Console.WriteLine("Would you like to try again... (Y/N) ");
                string tryAgain = Console.ReadLine();
                if (tryAgain == ("y")){
                    Console.WriteLine("Thanks for using this calculator... ");
                    break;
                }
            }
        }
    }
}
