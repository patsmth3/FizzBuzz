using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop solution");

            string text;
            
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                    text = "FizzBuzz";
                else if  (i % 3 == 0)
                    text = "Fizz";
                else if (i % 5 == 0)
                    text = "Buzz";
                else
                    text = i.ToString();
                
                Console.WriteLine(text);
                 
            }
        }
    }
}