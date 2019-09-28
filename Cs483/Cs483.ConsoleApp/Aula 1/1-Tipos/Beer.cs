using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs483.ConsoleApp.Aula_1._1_Tipos
{
    class Beer
    {
        public string Graduacao { get; set; }
        public string Cor { get; set; }
        public int IBU { get; set; }

        public override string ToString()
        {
            return $"{Graduacao} - {Cor} - {IBU}";
        }
    }
}
