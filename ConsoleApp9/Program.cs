using System;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {
                    Console.WriteLine("Second operand is evaluated.");
                    double a, b, c;
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = int.Parse(Console.ReadLine());
                    bool r = (a > 3) && (b > 3) && (c > 3);
                    Console.WriteLine(r);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

    }
}