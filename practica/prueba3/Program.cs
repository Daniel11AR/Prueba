using System;
using KYLib.ConsoleUtils;
namespace prueba3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var table = new ConsoleTable();
			table.AddColumns("ID", "Nombre", "Apellido");
			table.AddRow(0, "Juan Pablo", "Calle Grafe");
			table.AddRow(1, "Daniel", "Arango");
			Cons.Line = table.ToString();

            
        }
    }
}
