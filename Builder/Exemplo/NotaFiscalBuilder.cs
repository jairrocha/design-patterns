using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Exemplo
{
    public class NotaFiscalBuilder
    {
        private String razaoSocial;
        private String cnpj;
        private DateTime dataDeEmissao;
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        private List<Item> itens;
        private string observacoes;

        #region [Construtor]
        public NotaFiscalBuilder()
        {
            this.dataDeEmissao = DateTime.Now;
            this.itens = new List<Item>();
        }
        #endregion

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;
            return this;
        }
        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.cnpj = cnpj;
            return this;
        }
        public NotaFiscalBuilder ComItem(Item item)
        {
            this.itens.Add(item);
            this.ValorBruto += item.Valor;
            this.Impostos += item.Valor * 0.05;
            return this;
        }
        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.observacoes = observacoes;
            return this;
        }
        
        public NotaFiscal Builder()
        {
            return new NotaFiscal(razaoSocial, cnpj, dataDeEmissao,
                ValorBruto, Impostos, itens, observacoes);
        }



    }
}
