using System;

namespace ciclos
{
    class Program
    {
        static void Main(string[] args)

        {
            /* Console.WriteLine("Ingrese la cantidad de productos a pagar");
            int cantidad = int.Parse(Console.ReadLine()); 
            int totalPago = 0;
            double descuento = 0.10;

            for (int i = 0; i < cantidad; i++)
            {
            Console.WriteLine("valor del producto" + (i+1));
            int valor = int.Parse(Console.ReadLine());
            totalPago += valor;
            }

            if (totalPago > 50000)
            {
                totalPago -= (int)(totalPago * descuento);
            }
            Console.WriteLine("El total de los productos es de: "+totalPago); */

            Console.WriteLine("Ingrese la cantidad de personas");
            int cant = int.Parse(Console.ReadLine());

            for (int i = 0; i <cant; i++)
            {
                Console.WriteLine("Ingrese el valor del impuesto");
                int impuesto = int.Parse(Console.ReadLine());

            if (impuesto > 500000)
            {
             impuesto -= (int)(impuesto*0.05);
             Console.WriteLine("El total de el impuesto es de: "+impuesto);

            }
            else
            {
                Console.WriteLine("El total del impuesto es de: "+impuesto);
            }

            

            }
            

            

     
        }
    }
}
