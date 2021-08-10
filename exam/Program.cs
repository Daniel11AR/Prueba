using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Numero de trabajadores contratados: ");
            int trabajadores = int.Parse(Console.ReadLine());
            double salarioSem = 500000;
            int ventas = 3;
            int suma;

            for (int i = 0; i < trabajadores; i++)
            {
                suma = 0;
                System.Console.WriteLine("Ingrese la venta del vendedor: " + (i + 1));


                for (int j = 0; j < ventas; j++)
                {
                    System.Console.WriteLine("Venta  " + (j + 1));
                    int valorVenta = int.Parse(Console.ReadLine());
                    suma += valorVenta;
                }

                if (suma > 500000)
                {
                    salarioSem += salarioSem * 0.10;
                    System.Console.WriteLine("El valor de su salario sera de: " + salarioSem);
                     suma = 0;
                }


                else
                {
                    suma=0;
                    System.Console.WriteLine("El valor de su salario sera de: " + salarioSem);
                }



            }


        }
    }
}
