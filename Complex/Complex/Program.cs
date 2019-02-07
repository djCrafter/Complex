using System;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(5, 4);
            Complex b = new Complex(6, 8);

            Console.WriteLine(a + b);
            Console.WriteLine(a * b);
            Console.WriteLine(a - b);
            Console.WriteLine(a / b);
            Console.WriteLine(a == b);

            Console.ReadLine();
        }
    }
}
