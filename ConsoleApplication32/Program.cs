using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the value of a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value of b : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select '1' for Addition, '2' for subraction, '3' for Multiplication and '4' for division");
            int z = Convert.ToInt32(Console.ReadLine());
            int result=Calculator(a, b, z);
            Console.WriteLine("Result is " +result);


        }
        public static int Calculator(int a, int b, int z)
        {
            switch (z)
            {
                case 1:
                    return a + b;
                    
                case 2:
                    if (a > b)
                    {
                        return a - b;
                    }
                    else
                    {
                        return b - a;
                    }
                    
                    
                case 3: return a * b;
                   
                case 4: return a / b;
                    
            }
            return -1;
           
        }

    }
}
