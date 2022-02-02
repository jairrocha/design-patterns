using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Desafio
{
    public interface IEstadoDeUmaConta
    {
        void Saque(double valor);
        void Deposita(double valor);
          
    }
}

