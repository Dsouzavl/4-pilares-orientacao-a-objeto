using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Humano
    {
        public string Nome { get; set; }

        public int  Idade { get; set; }

        public double Altura { get; set; }

        public void Falar()
        {
            Console.WriteLine($"Oi, meu nome é {this.Nome}");
            Console.ReadLine();

        }

        public void Andar()
        {
            Console.WriteLine("Andando!");
            Console.ReadLine();
        }

    }
}
