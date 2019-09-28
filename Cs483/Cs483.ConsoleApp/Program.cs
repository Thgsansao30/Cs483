using Cs483.ConsoleApp.Aula_1._2_TiposInteiros;
using Cs483.ConsoleApp.Aula_1._3_PontoFlutuante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                MontaMenu();
                Console.WriteLine("Digite um opção");
                opcao = Convert.ToInt32(Console.ReadLine());


                Tipos tipos = new Tipos();
                TiposInteiros tiposInteiros = new TiposInteiros();
                PontoFlutuante pontoflutuante = new PontoFlutuante();
                switch (opcao)
                {
                        case 1:
                        tipos.Executa();
                        break;

                        case 2:
                        tiposInteiros.Executa();
                        break;

                        case 3:
                        pontoflutuante.Executa();
                        break;

                    default:
                    break;
                }
                Console.ReadLine();
                Console.Clear();


                tipos.Executa();
                Console.Clear();
            } while (opcao != 0) ;
            
        }

        private static void MontaMenu()
        {
            Console.WriteLine("====== CS 483 ======");
            Console.WriteLine("0-Sair");
            Console.WriteLine("1-Tipos por Valor");
            Console.WriteLine("2-Tipos Inteiros");
            Console.WriteLine("3-Ponto Flutuante");
            Console.WriteLine("4-Booleanos");
            Console.WriteLine("5-Structs");
           
        }
    }
}
