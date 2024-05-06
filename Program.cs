using System;
using System.Collections.Generic;

namespace Dado15Caras
{
    internal class Program
    {
        static string[] Colores = new string[] { "Rojo", "Verde", "Azul", "Amarillo", "Naranja", "Morado", "Blanco", "Negro", "Gris", "Rosa", "Marrón", "Turquesa", "Violeta", "Beige", "Cyan" };

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Dado de 15 caras sin retorno, pulse enter para iniciar la primera tirada");
            Console.ReadLine();
            RepiteTirada();
        }

        public static void RepiteTirada()
        {
            string respuesta;
            do
            {
                TiradaDado();
                Console.WriteLine("Quiere hacer otra tirada? (si/no)");
                respuesta = Console.ReadLine().ToLower();
            } while (respuesta == "si");
        }

        public static void TiradaDado()
        {
            List<int> numerosDisponibles = GeneraNumerosUnicos();
            Random random = new Random();
            int indiceAleatorio = random.Next(numerosDisponibles.Count);
            int numeroElegido = numerosDisponibles[indiceAleatorio];
            Console.WriteLine("El número " + numeroElegido + " corresponde al color " + Colores[numeroElegido - 1]);
            numerosDisponibles.RemoveAt(indiceAleatorio);
        }

        public static List<int> GeneraNumerosUnicos()
        {
            List<int> numeros = new List<int>();
            for (int i = 1; i <= 15; i++)
            {
                numeros.Add(i);
            }
            return numeros;
        }
    }
}
