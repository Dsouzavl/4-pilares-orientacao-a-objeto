using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public interface IWebPage
    {
        string Link { get; set; }

        string Botao { get; set; }

        string Texto { get; set; }

        void FazerCadastro();

        void FazerLogin();
    }
}
