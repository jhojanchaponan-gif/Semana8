using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la nota final: ");
            double nota = double.Parse(Console.ReadLine());

            if (EsNotaValida(nota))
            {
                string clasificacion = ClasificarNota(nota);
                MostrarReporte(nota, clasificacion);
            }
            else
            {
                Console.WriteLine("Error: la nota debe estar entre 0 y 20.");
            }
        }

        // Función con retorno para validar la nota
        static bool EsNotaValida(double nota)
        {
            return nota >= 0 && nota <= 20;
        }

        // Función con retorno para clasificar la nota
        static string ClasificarNota(double nota)
        {
            if (nota >= 18)
            {
                return "Excelente";
            }
            else if (nota >= 14)
            {
                return "Bueno";
            }
            else if (nota >= 11)
            {
                return "Regular";
            }
            else
            {
                return "Desaprobado";
            }
        }

        // Procedimiento void para mostrar el reporte
        static void MostrarReporte(double nota, string clasificacion)
        {
            Console.WriteLine("\n=== REPORTE FINAL ===");
            Console.WriteLine($"Nota ingresada: {nota:F2}");
            Console.WriteLine($"Clasificación: {clasificacion}");
        }
    }
}
