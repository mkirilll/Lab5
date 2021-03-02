using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public class Fibonacci
    {
        public int ElementsQuantity { get; set; }

        public void IterativeFibonacci(int elementsQuantity)
        {
            uint[] result = new uint[elementsQuantity];
            int counter = 0;

            while (counter < elementsQuantity)
            {
                if (counter > 1)
                {
                    try
                    {
                        result[counter] = checked(result[counter - 1] + result[counter - 2]);
                        counter++;
                    }
                    catch(OverflowException ex)
                    {
                        Console.WriteLine("\n{0}", ex.Message);
                        return;
                    }                
                }
                else
                {
                    result[counter] = 1;
                    counter++;
                }
            }
            Console.WriteLine($"\nFibonacci numbers calculated iteratively: {string.Join(", ", result)}");
        }

        public void RecursiveFibonacci(int elementsQuantity)
        {
            uint[] result = new uint[elementsQuantity];
            PrintRecursiveFibonacci(result: result, elementsQuantity: result.Length);
        }

        public void PrintRecursiveFibonacci(uint[] result, int elementsQuantity, int counter = 0)
        {
            if (counter == elementsQuantity)
            {
                Console.WriteLine($"\n\nFibonacci numbers calculated recursively: {string.Join(", ", result)}");
            }
            else
            {
                if (counter == 0 || counter == 1)
                {
                    result[counter] = 1;
                }
                else
                {
                    try
                    {
                        result[counter] = checked(result[counter - 1] + result[counter - 2]);
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine("\n{0}", ex.Message);
                        return;
                    }
                }
                PrintRecursiveFibonacci(result, result.Length, counter + 1);
            }
        }    

        public void ClosedFormFibonacci(int elementsQuantity)
        {
            uint[] result = new uint[elementsQuantity];
            double dividend = ((1 + Math.Sqrt(5)) / 2);
            double divider = ((1 - Math.Sqrt(5)) / 2);

            for (int i = 1; i <= elementsQuantity; i++)
            {
                try 
                {
                    checked
                    {
                        result[i - 1] = (uint)Math.Round(((Math.Pow(dividend, i) - Math.Pow(divider, i)) / Math.Sqrt(5)), 0);
                    }
                }
                catch(OverflowException ex)
                {
                    Console.Write("\n{0}", ex.Message);
                    return;
                }
            }

            Console.Write($"\n\nFibonacci numbers calculated by a closed form: {string.Join(", ", result)}");         
        }
    }
}
