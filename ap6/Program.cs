using System;

namespace ap6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            //captura de datos desde consola 
            Console.WriteLine("introduzca un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca otro numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("la suma es: " + suma(num1, num2));
            Console.WriteLine("la resta es: " + resta(num1, num2));
            Console.WriteLine("la multiplicacion es: " + multi(num1, num2));
            Console.WriteLine("la division es: " + divi(num1, num2));
        }
    }
}
