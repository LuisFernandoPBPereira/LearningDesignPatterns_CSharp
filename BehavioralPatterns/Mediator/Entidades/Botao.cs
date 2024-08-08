using Mediator.Interfaces;

namespace Mediator.Entidades;

public class Botao : Componente
{
    public string NomeDoBotao { get; set; } = string.Empty;

    public Botao(IMediator mediator, string nomeDoBotao) : base(mediator)
    {
        NomeDoBotao = nomeDoBotao;
    }

    public void Click()
    {
        Console.WriteLine($"{NomeDoBotao} clicado");
        Mediator.Notificar(sender: this, evento: "Click");
    }
}
