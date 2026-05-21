using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static double calcularCostoAgua(int m3)
        {
            double costo;

            if (m3 <= 20)
            {
                costo = m3 * 1.80;
            }
            else
            {
                costo = (20 * 1.80) + ((m3 - 20) * 2.50);
            }

            return costo;
        }

        static void mostrarRecibo(int m3, double costo)
        {
            Console.WriteLine("Consumo: " + m3 + " m3");
            Console.WriteLine("Costo total: S/" + costo.ToString("0.00"));
        }
        static void Main(string[] args)
        {
            int m3;
            double costo;

            Console.Write("Ingrese el consumo de agua en m3: ");
            m3 = int.Parse(Console.ReadLine());

            costo = calcularCostoAgua(m3);

            mostrarRecibo(m3, costo);

            Console.ReadKey();
        }
    }
}
