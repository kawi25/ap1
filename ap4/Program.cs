using System;

namespace ap4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            int cont = 0;

            Console.WriteLine("ingrese el numero de repeticiones que desea");
            int limite = int.Parse(Console.ReadLine());

            while (condition)
            {
                if (cont == limite)
                    condition = false;
                cont++;

            }

        }
    }
}

