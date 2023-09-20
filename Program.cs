using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5_ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero de notas: ");
            int cantidadenotas = int.Parse(Console.ReadLine());

            int promedio = 0;

            for (int i = 1; i <= cantidadenotas; i++)
            {
                Console.Write("Ingrese la nota " + i + ": ");
                int nota = int.Parse(Console.ReadLine());
                promedio = promedio + nota;
            }
            Console.WriteLine("El promedio es " + promedio/cantidadenotas);
            Console.ReadKey();
        }
    }
}
