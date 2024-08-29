using System;

namespace retos_soluciones.retos
{
    internal class Reto2
    {
        public static void Ejecutar()
        {
            // Instrucciones:
            // Escribe un programa que se encargue de comprobar si un número es o no primo.
            // Hecho esto, imprime los números primos entre 1 y 100.

            Console.WriteLine("Ejecutando Reto 2...");

            Console.WriteLine("Ingrese un número:");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (EsPrimo(numero))
                {
                    Console.WriteLine($"El número {numero} es primo.");
                }
                else
                {
                    Console.WriteLine($"El número {numero} no es primo.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }

            Console.WriteLine("Números primos entre 1 y 100:");
            for (int i = 1; i <= 100; i++)
            {
                if (EsPrimo(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        private static bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

