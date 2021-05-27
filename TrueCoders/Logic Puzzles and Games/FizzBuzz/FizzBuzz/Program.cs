using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop solution");

            string text;
            
            //if (int i = 100; i >= 1; i--) will do it in reverse
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
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Recursive Solution");
            Console.WriteLine("");
            RecursiveSolution(100);

        }
        private static void RecursiveSolution(int n)
        {
            string text = "";
            
            //condition that stops the recursion
            if (n < 1)
                return;
            
            if (n % 15 == 0)
                text = "FizzBuzz";
            else if  (n % 3 == 0)
                text = "Fizz";
            else if (n % 5 == 0)
                text = "Buzz";
            else
                text = n.ToString();
            
            Console.WriteLine(text);
            RecursiveSolution(n - 1);
        }
    }
}