using System;

namespace matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de empleados");
            int cantidad = int.Parse(Console.ReadLine());
            String [,] mat = new String [cantidad,4];
            int suma = 0;
            double promedio = 0;

            for (int i=0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese acontinuación los datos:");
                
                for (int j=0; j < 4; j++)
                {
                    Console.WriteLine("Ingrese el nombre del invitado "+ (i+1));
                    String nombre = Console.ReadLine();
                    mat [i,j]=nombre;

                    
                    Console.WriteLine("Ingrese su Genero: ");
                    String genero = (Console.ReadLine());
                    mat [i, 1]= genero;
                    
                    
                    Console.WriteLine("Ingrese su edad:");
                    int edad = int.Parse(Console.ReadLine());
                    edad= int.Parse(mat [i, 2]);
                    suma += edad;
                
                
                    Console.WriteLine("Ingrese la cantidad de regalos:");
                    int regalos = int.Parse(Console.ReadLine());
                    regalos= int.Parse(mat [i, 2]);  
                    
                }
            
            }
             promedio = suma/cantidad;
            Console.WriteLine("El promedio de edad es de: "+promedio);

            
            

        }
    }
}
