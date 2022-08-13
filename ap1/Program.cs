using System;

namespace ap1
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese sunota de promedio");
            double nota = double.Parse(Console.ReadLine());
            
           if (nota >= 0 && nota <= 10)
           {
                if (nota >= 6)
                {
                    Console.WriteLine("Aprobado");
                }
                else if (nota >= 5)
                {

                    Console.WriteLine("reposicion");
                }
                else
                {
                    Console.WriteLine("reprobado");
                }
           }
           else
           {
                Console.WriteLine("la nota no es correcta")
           }

        }

    }

}

