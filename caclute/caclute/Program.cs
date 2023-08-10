using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caclute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number ");
            int x = Convert.ToInt32(Console.ReadLine());//convert   stringتحول لك من int مهمه
            Console.WriteLine("enter the number ");
            int y = Convert.ToInt32(Console.ReadLine());//convert   stringتحول لك من int 
            Console.WriteLine("enter the quality");
            string z = Console.ReadLine();
            if (z == "*")
            {
                Console.WriteLine($"{x}*{y}={x * y}");
            }
            if (z == "+")
            {
                Console.WriteLine($"{x}+{y}={x + y}");
            }
            if (z == "-")
            {
                Console.WriteLine($"{x}-{y}={x - y}");
            }
            if (z == "/")
            {
                Console.WriteLine($"{x}/{y}={x / y}");
            }



           


        }
    }
}
