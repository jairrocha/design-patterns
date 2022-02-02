using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Filtro
{
    public class FiltroDataAberturaMesCorrente:Filtro
    {
        public override List<Conta> ContasFiltradas { get; set; }
        
        #region [Construtores]
        public FiltroDataAberturaMesCorrente(){}
        public FiltroDataAberturaMesCorrente(Filtro outroFiltro) : base(outroFiltro){}

        #endregion

        public override IEnumerable<Conta> Filtra(IList<Conta> contas)
        {

            ContasFiltradas = new List<Conta>();

            var query =contas
                .Where(c => c.DataAbertura.Month == DateTime.Now.Month)
                .ToList();
            
            ContasFiltradas.AddRange(query);

            query = (List<Conta>)Proximo(contas);
            ContasFiltradas.AddRange(query);

            return ContasFiltradas;

        }
              
    }
}
