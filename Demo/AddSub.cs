using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class AddSub
    {
        public void Add()
        {
            Console.Write("Enter first Number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Addition of two numbers : " + sum);
        }

      
    }
}
