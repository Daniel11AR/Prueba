using System;

namespace practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("Ingrese la cantidad de personas que ingresaran");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0;  i<cantidad; i++)
            {
                System.Console.WriteLine("Ingrese el genero de la persona: "+ (i+1));
                String genero = Console.ReadLine();
            }

            Console.WriteLine("La cantidad de personas que asistieron a la fiesta es de:" + cantidad); 

            Console.WriteLine("Ingrese la cantidad de productos que comprara");
            int productos = int.Parse(Console.ReadLine());
            int valorFinal = 0;

            for (int i = 0; i < productos; i++)
            {
                Console.WriteLine("Ingrese el valor del producto: "+ (i+1));
                int valor = int.Parse(Console.ReadLine());
                valorFinal += valor;
            }

            Console.WriteLine("El valor total de los productos comprados es de: "+ (valorFinal)); 



             Console.WriteLine("Ingrese Cantidad de autos que ingresaron a la ciudad: ");
            int cantidadCoches = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadCoches; i++)
            {
                Console.WriteLine("Ingrese el codigo del automovil: "+ (i+1));
                int codigo = int.Parse(Console.ReadLine());

                if (codigo == 1 || codigo == 2)
                Console.WriteLine("El automovil pertenece al equipo águilas doradas");
                else if( codigo == 3 || codigo == 4 )
                Console.WriteLine("El automovil pertenece al equipo atetico nacional");
                else if( codigo == 5 || codigo == 6 )
                Console.WriteLine("El automovil pertenece al equipo medellín");
                else if( codigo == 7 || codigo == 8)
                Console.WriteLine("El automovil pertenece al equipo envigado");
                else if( codigo == 9 || codigo == 0 )
                Console.WriteLine("El automovil pertenece al equipo itagui");
                else
                {
                    Console.WriteLine("El automovil no esta registrado con ese codigo");
                } 


                
                    
                

                


            }
        }
    }
}

