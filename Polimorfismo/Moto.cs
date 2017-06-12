using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Moto : Automovel
    {
        public override void Freiar()
        {
            Console.WriteLine("Apertando freio da moto");
            Console.ReadLine();
            base.Freiar();
        }
    }
}
