using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Filtro
{
    public abstract class Filtro
    {

        private readonly Filtro outroFiltro;
        public abstract List<Conta> ContasFiltradas { get; set; }

        #region [Construtores]
        protected Filtro(Filtro outroFiltro)
        {
            this.outroFiltro = outroFiltro;
        }
        public Filtro()
        {
            outroFiltro = null;
        }
        #endregion

        public abstract IEnumerable<Conta> Filtra(IList<Conta> contas);

        protected IEnumerable<Conta> Proximo(IList<Conta> contas)
        {
            return (outroFiltro != null ? outroFiltro.Filtra(contas) : new List<Conta>());
        }




    }
}
