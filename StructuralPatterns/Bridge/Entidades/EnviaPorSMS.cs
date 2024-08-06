using Bridge.Interfaces;

namespace Bridge.Entidades;

public class EnviaPorSMS : IEnviador
{
    public void Envia(IMensagem mensagem)
    {
        Console.WriteLine("Enviando a mensagem por SMS");
        Console.WriteLine(mensagem.Formata());
    }
}
