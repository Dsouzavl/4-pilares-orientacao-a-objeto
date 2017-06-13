using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public abstract class Cao
    {
        public string Raca;

        public string Nome;

        public int Idade;

        abstract public void Latir();

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
