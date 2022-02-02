using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Filtro
{
    public class FiltroSaldoMenorQue100Mil : Filtro
    {
        #region [Construtor]
        public FiltroSaldoMenorQue100Mil(Filtro outroFiltro) : base(outroFiltro){}
        public FiltroSaldoMenorQue100Mil(){}
        #endregion

        public override List<Conta> ContasFiltradas { get; set; }

        public override IEnumerable<Conta> Filtra(IList<Conta> contas)
        {
            ContasFiltradas = new List<Conta>();

            var query = contas
                .Where(c => c.Saldo < 100000)
                .ToList();

            ContasFiltradas.AddRange(query);

            query = (List<Conta>)Proximo(contas);

            ContasFiltradas.AddRange(query);

            return ContasFiltradas;
        }
    }
}
