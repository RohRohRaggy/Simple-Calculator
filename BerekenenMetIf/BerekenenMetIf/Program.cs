using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  
    Max Nikoliszyn
    Student Gilde Opleidingen
*/
namespace BerekenenMetIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read out numbers and operators
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Which operator would you like to use?(+, -, *, /) ");
            string oper = Console.ReadLine();

            double result = 0;
            bool validInput = true;

            //if else operator rule assignment
            if (oper == "+")
            {
                result = num1 + num2;
            }
            else if (oper == "-")
            {
                result = num1 - num2;
            }
            else if (oper == "*")
            {
                result = num1 * num2;
            }
            else if (oper == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("ERROR: Can not devide by 0");
                    validInput = false;
                }
            }
            else
            {
                Console.WriteLine("ERROR: Invalid operator was chosen");
                validInput = false;
            }
            if (validInput)
            {
                Console.WriteLine("Result: " + result);
            }
        }
    }
}
