using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Exemplo
{
    public class NotaFiscal
    {
        public String RazaoSocial { get; private set; }
        public String Cnpj { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public List<Item> Itens { get; private set; }
        public string Observacoes { get; private set; }

        #region [Construtor]
        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao, 
            double valorBruto, double impostos, List<Item> itens, string observacoes)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataDeEmissao = dataDeEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Itens = itens;
            Observacoes = observacoes;
        }
        #endregion


    }
}
