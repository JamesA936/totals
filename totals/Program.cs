using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user in input 10 numbers
            Console.WriteLine("Type 10 numbers.");
            //Declaerin ght everiables
            decimal num1;
            decimal num2;
            decimal num3;
            decimal num4;
            decimal num5;
            decimal num6;
            decimal num7;
            decimal num8;
            decimal num9;
            decimal num10;


            num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Value 1 added.");
            num2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Value 2 added.");
            num3 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Value 3 added.");
            num4 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Value 4 added.");
            num5 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Value 5 added.");
            num6 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Value 6 added.");
            num7 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Value 7 added.");
            num8 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Value 8 added.");
            num9 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Value 9 added.");
            num10 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Value 10 added.");



            Console.WriteLine("The total is " + num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10);


            Console.ReadLine();
        }
    }
}
