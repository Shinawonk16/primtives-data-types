using System;

namespace Question_three
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            float u = 6;
            float n = 12;
            float r =(u-n);
            bool equal = Math.Abs(r) < 0.000001;
            Console.WriteLine(equal);
        }
    }
}
