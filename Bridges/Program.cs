using System;

namespace Bridges
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnviador dispositivo = null;
            IMessagem mensagem = null;


            mensagem = new MenssagemAdministrativa("Jair");
            
            dispositivo = new Celular();
            mensagem.Enviador = dispositivo;
            mensagem.Envia();

            dispositivo = new Fax();
            mensagem.Enviador = dispositivo;
            mensagem.Envia();


            mensagem = new MenssagemCliente("Jair");

            dispositivo = new Celular();
            mensagem.Enviador = dispositivo;
            mensagem.Envia();

            dispositivo = new Fax();
            mensagem.Enviador = dispositivo;
            mensagem.Envia();


        }
    }
}
