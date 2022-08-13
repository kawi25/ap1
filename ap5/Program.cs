using System;

namespace ap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {

                Console.WriteLine("ingrese un numero entero (con 0 se finaliza):");
                num = int.Parse(Console.ReadLine());

                if (num >= 100)
                {
                    Console.WriteLine("tiene 3 dijitos.");
                }
                else if (num >= 10)
                {
                    Console.WriteLine("tiene dos digitos.");
                }
                while (num != 0) ;
            }
        }
    }
}