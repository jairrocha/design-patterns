namespace Bridges
{
    internal class MenssagemAdministrativa : IMessagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }


        #region [CONSTRUTOR]
        public MenssagemAdministrativa(string nome)
        {
            this.nome = nome;
        }
        #endregion

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return $"Mensagem para o administrador {nome}\n";
        }
    }
}