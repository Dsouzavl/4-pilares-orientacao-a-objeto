using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Homem : Humano
    {
        public Homem(string nome, int idade, double altura):base(nome, idade, altura) { };
        
        public bool TemBarba { get; set; }
    }
}
