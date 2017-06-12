using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Moto moto = new Moto();

            carro.Freiar();
            moto.Freiar();
        }
    }
}
