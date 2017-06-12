using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano humano = new Humano();

            humano.Nome = "Linus Torvalds";
            humano.Idade = 47;
            humano.Altura = 1.82;

            humano.Falar();
            humano.Andar();

            Homem homem = new Homem();

            homem.Nome = "Linus Torvalds";
            homem.Idade = 47;
            homem.Altura = 1.82;

            homem.Falar();
            homem.Andar();
        }
    }
}
