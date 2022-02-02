using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridges
{
    class MenssagemCliente : IMessagem
    {
        private string nome;

        public IEnviador Enviador { get; set; }

        public MenssagemCliente(string nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return $"Menssagem para o cliente {nome}\n";
        }
    }
}
