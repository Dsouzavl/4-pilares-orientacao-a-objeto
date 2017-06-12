using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class WebPage : IWebPage
    {
        public string Link { get; set; }

        public string Botao { get; set; }

        public string Texto { get; set; }

        public void FazerLogin()
        {
            Console.Write("Fazendo login!");
            Console.Read();
        }

        public void FazerCadastro()
        {
            Console.Write("Fazendo cadastro!");
            Console.Read();
        }
    }
}
