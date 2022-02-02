using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Contrato
    {
        public DateTime Data { get; set; }
        public string Cliente { get; set; }
        public TipoContrato Tipo { get; set; }
        public Historico historico { get; set; }


        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            Data = data;
            Cliente = cliente;
            Tipo = tipo;
            historico = new Historico();
        }
        public void Avanca()
        {
            if (this.Tipo == TipoContrato.Novo) this.Tipo = TipoContrato.EmAdamento;
            else if (this.Tipo == TipoContrato.EmAdamento) this.Tipo = TipoContrato.Acertado;
            else if (this.Tipo == TipoContrato.Acertado) this.Tipo = TipoContrato.Concluido;
            else return;

            historico.Adiciona(SalvaEstado());

        }
        private Estado SalvaEstado()
        {
            return new Estado(new Contrato(this.Data, this.Cliente, this.Tipo));
        }

    }
}
