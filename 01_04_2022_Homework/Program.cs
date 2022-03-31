using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04_2022_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("value of the varibale 'a': ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("value of the varibale 'b': ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($@"Sum: {Calculator.Sum(a, b)}
Subtract: {Calculator.Subtract(a, b)}
Multiply: {Calculator.Multiply(a, b)}
Divide: {Calculator.Divide(a, b)}
Power of a: {a.Pow(2)}
Power of b: {b.Pow(4)}");
            Console.ReadLine();
        }
    }
}
