using System;

namespace retos_soluciones.retos
{
    internal class Reto1
    {
        public static void Ejecutar()
        {
            // Instrucciones:
            // Escribe un programa que muestre por consola (con un print) los números de 1 a 100 (ambos incluidos y con un salto de línea entre cada impresión),
            // sustituyendo los siguientes:
            // - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
            // - Múltiplos de 3 por la palabra "fizz"
            // - Múltiplos de 5 por la palabra "buzz"

            Console.WriteLine("Ejecutando Reto 1...");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
