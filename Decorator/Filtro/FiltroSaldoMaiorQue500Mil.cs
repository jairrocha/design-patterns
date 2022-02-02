using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Filtro
{
    public class FiltroSaldoMaiorQue500Mil : Filtro
    {
        #region [Construtores]
        public FiltroSaldoMaiorQue500Mil(Filtro outroFiltro) : base(outroFiltro){}
        public FiltroSaldoMaiorQue500Mil(){}
        #endregion

        public override List<Conta> ContasFiltradas { get; set; }

        public override IEnumerable<Conta> Filtra(IList<Conta> contas)
        {
            ContasFiltradas = new List<Conta>();

            var query = contas
                        .Where(c => c.Saldo > 500000)
                        .ToList();

            ContasFiltradas.AddRange(query);

            query = (List<Conta>)Proximo(contas);
            ContasFiltradas.AddRange(query);

            return ContasFiltradas;

        }
    }
}
