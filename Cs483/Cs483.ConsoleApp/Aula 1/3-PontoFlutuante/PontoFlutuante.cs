using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula_1._3_PontoFlutuante
{
    class PontoFlutuante
    {
        public void Executa()
        {
            Console.WriteLine("Ponto Flutuante");
            Float();

            Double();
            decimal salario = 1050.00m;
            decimal salariob = 250.00m;
            decimal somaE = salario + salariob;
            Console.WriteLine($"Saklario professor: {somaE}");

            ExibirPOntoFlutuante();

        }

        private static void Double()
        {
            double vlBeerD = 6.15;
            double vlBeerAD = 2.10;
            double somaD = vlBeerD + vlBeerAD;
            Console.WriteLine($"VlB: {vlBeerD} + vlBA: {vlBeerAD} = {somaD}");
            if ((vlBeerD + vlBeerAD) == somaD)
            {
                Console.WriteLine("É igual");
            }
            if (somaD == 8.25)
            {
                Console.WriteLine("É igual a 8,25");
            }

            double massaT = 5.972e24;
            Console.WriteLine($"A massa da terra: ");
        }

        private static void Float()
        {
            float vlBeer = 6.32f;
            float vlBeerA = 2.15f;
            float soma = vlBeer + vlBeerA;
            Console.WriteLine($"VlB: {vlBeer} + vlBA: {vlBeerA} = {soma}");
        }

        private static void ExibirPOntoFlutuante()
        {
            // ==== float => Single
            Console.WriteLine($"Valor minimo : {float.MinValue}");
            Console.WriteLine($"Valor maximo : {float.MaxValue}");

            // ==== float => Double
            Console.WriteLine($"Valor minimo : {double.MinValue}");
            Console.WriteLine($"Valor maximo : {double.MaxValue}");

            // ==== float => Decimal
            Console.WriteLine($"Valor minimo : {decimal.MinValue}");
            Console.WriteLine($"Valor maximo : {decimal.MaxValue}");
        }
    }
}
