using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consloe_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defining two variables
            float num1;
            float num2;
            //welcome note
            Console.WriteLine("welcome to the calculator");
            Console.WriteLine("enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("press the key to perform your operation");
            Console.WriteLine("To add , press : \"A\"");
            Console.WriteLine("to subtract, press: \"S\"");
            Console.WriteLine("to multiply, press: \"M\"");
            Console.WriteLine("to devide, press: \"D\"");

            switch (Console.ReadLine())
            {

                case "a":
                    Console.WriteLine($"your result : {num1} + {num2} = " + (num1 +num2));
                    break;
                case "s":
                    Console.WriteLine($"your result :{num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"your result :{num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    while (num2 == 0){
                        Console.WriteLine("the value cannot be 0");
                        Console.WriteLine("enter the second number again: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        break;

                    }
                   
                    Console.WriteLine($"your result :{num1} / {num2} = " + (num1 / num2));
                    break;

            }
            Console.ReadKey();
            


        }
    }
}
