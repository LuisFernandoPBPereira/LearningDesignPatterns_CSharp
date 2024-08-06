using Bridge.Interfaces;

namespace Bridge.Entidades;

public class EnviaPorEmail : IEnviador
{
    public void Envia(IMensagem mensagem)
    {
        Console.WriteLine("Enviando mensagem por e-mail");
        Console.WriteLine(mensagem.Formata());
    }
}
