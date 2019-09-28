using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula_1._2_TiposInteiros
{
    public class TiposInteiros
    {
        public void Executa()
        {
            Conversoes();

            ExibeTiposInteiro();
        }

        private static void Conversoes()
        {
            Console.WriteLine("TiposInteiros");

            char l = 'T';
            int n = l;
            Console.WriteLine($"Letra: {n}");

            int idM = 381;
            byte idade = (byte)idM;
            Console.WriteLine($"Idade Thiago: {idade}");
        }

        private void ExibeTiposInteiro()
        {
            // ==== char => char
            Console.WriteLine($"Valor minimo : {char.MinValue}");
            Console.WriteLine($"Valor maximo : {char.MaxValue}");
          

            // ==== short => int16
            Console.WriteLine($"Valor minimo : {short.MinValue}");
            Console.WriteLine($"Valor maximo : {short.MaxValue}");
            // ==== ushort => uint16
            Console.WriteLine($"Valor minimo : {ushort.MinValue}");
            Console.WriteLine($"Valor maximo : {ushort.MaxValue}");


            // ==== short => Byte
            Console.WriteLine($"Valor minimo : {byte.MinValue}");
            Console.WriteLine($"Valor maximo : {byte.MaxValue}");
            // ==== short => SByte
            Console.WriteLine($"Valor minimo : {sbyte.MinValue}");
            Console.WriteLine($"Valor maximo : {sbyte.MaxValue}");


         

            // ==== int => int32
            Console.WriteLine($"Valor minimo : {int.MinValue}");
            Console.WriteLine($"Valor maximo : {int.MaxValue}");
            // ==== int => uint32
            Console.WriteLine($"Valor minimo : {uint.MinValue}");
            Console.WriteLine($"Valor maximo : {uint.MaxValue}");



            // ==== long => int64
            Console.WriteLine($"Valor minimo : {long.MinValue}");
            Console.WriteLine($"Valor maximo : {long.MaxValue}");
            // ==== long => uint64
            Console.WriteLine($"Valor minimo : {ulong.MinValue}");
            Console.WriteLine($"Valor maximo : {ulong.MaxValue}");

        }
    }
}
