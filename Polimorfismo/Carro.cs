using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Carro : Automovel
    {
        public override void Freiar()
        {
            Console.WriteLine("Apertando embreagem do carro");
            Console.WriteLine("Apertando freio do carro");
            Console.ReadLine();
            base.Freiar();
        }
    }
}
