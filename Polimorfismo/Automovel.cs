using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Automovel
    {
        public string Tipo { get; set; }

        public virtual void Freiar()
        {
            Console.WriteLine("Freiando");
            Console.ReadLine();
        }
    }
}
