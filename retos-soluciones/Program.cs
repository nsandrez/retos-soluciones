using System;
using retos_soluciones.retos;

namespace RetosSoluciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona el reto que deseas ejecutar");
            Console.WriteLine("1. Reto 1");
            Console.WriteLine("2. Reto 2");

            string seleccion = Console.ReadLine();

            switch (seleccion)
            {
                case "1":
                    Reto1.Ejecutar();
                    break;
                case "2":
                    Reto2.Ejecutar();
                    break;
                default:
                    Console.WriteLine("Selección inválida.");
                    break;
            }
        }
    }
}