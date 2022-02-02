namespace Bridges
{
    public interface IMessagem
    {
        IEnviador Enviador { get; set; }
        void Envia();
        string Formata();

    }
}