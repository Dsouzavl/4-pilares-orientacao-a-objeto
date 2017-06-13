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
            Humano humano = new Humano("Linus Torvalds",47,1.82);
            
            humano.Falar();
            humano.Andar();

            Homem homem = new Homem("Linus Torvalds",47,1.82);

            homem.Falar();
            homem.Andar();
        }
    }
}
