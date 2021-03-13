using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
           string entrada; 
           double milhas, quilometros; 

           Console.Write("Entre com a medida (em milhas):");
           entrada = Console.ReadLine(); 

           milhas = Convert.ToDouble(entrada);
           quilometros = milhas * 1609;

           Console.WriteLine("\nEquivalente em quilômetros: ");
           Console.WriteLine($"{quilometros:N2} km");



        }
    }
}
