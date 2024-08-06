using Bridge.Interfaces;

namespace Bridge.Entidades;

public class MensagemCliente : IMensagem
{
    public string Nome { get; set; } = string.Empty;
    public IEnviador Enviador { get; set; }
    
    public MensagemCliente(string nome)
    {
        Nome = nome;
    }

    public void Envia()
    {
        Enviador.Envia(this);
    }

    public string Formata()
    {
        return $"Enviando mensagem para o cliente {Nome}";
    }
}
