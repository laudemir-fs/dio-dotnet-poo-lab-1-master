using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {   
            double pi = 3.14159, raio;

                raio = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("A=" + (pi * (raio * raio)).ToString("0,0000"));

                Console.ReadKey();
        }
    }
}
