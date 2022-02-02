namespace Visitor
{
    public class Numero:IExpressao
    {
        public int Valor { get; private set; }
        public Numero(int numero)
        {
            this.Valor = numero;
        }
        public int Avalia()
        {
            return Valor;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeNumero(this);
        }
    }
}