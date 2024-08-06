using Bridge.Interfaces;

namespace Bridge.Entidades;

public class MensagemAdministrativa : IMensagem
{
    public string Nome { get; set; } = string.Empty;
    public IEnviador Enviador { get; set; }

    public MensagemAdministrativa(string nome)
    {
        Nome = nome;
    }

    public void Envia()
    {
        Enviador.Envia(this);
    }

    public string Formata()
    {
        return $"Enviando a mensagem para o administrador {Nome}";
    }
}
