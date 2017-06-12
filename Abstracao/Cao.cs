using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    class Cao
    {
        public string Raca;

        public float Tamanho;

        public int Idade;

        public void Latir()
        {
            Console.Write("Woof!");
            Console.Read();
        }

        public void CorrerAtrasDoRabo()
        {
            Console.Write("Correndo!");
            Console.Read();
        }

        public void PegarOJornal()
        {
            Console.Write("Pegando!");
            Console.Read();
        }
    }
}
