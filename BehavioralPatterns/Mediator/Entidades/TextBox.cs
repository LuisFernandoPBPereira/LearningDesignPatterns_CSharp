using Mediator.Interfaces;

namespace Mediator.Entidades;

public class TextBox : Componente
{
    public string Valor { get; set; } = string.Empty;

    public TextBox(IMediator mediator) : base(mediator){}

    public void InserirValor(string valor)
    {
        Valor = valor;
        Console.WriteLine($"O valor do textbox inserido é: {valor}");

        Mediator.Notificar(sender: this, evento: "ValorInserido");
    }

    public void Habilitar()
    {
        Console.WriteLine("Textbox habilitado");
    }
    
    public void Desabilitar()
    {
        Console.WriteLine("Textbox desabilitado");
    }
}
