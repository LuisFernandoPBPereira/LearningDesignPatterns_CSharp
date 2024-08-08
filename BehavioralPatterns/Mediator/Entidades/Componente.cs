using Mediator.Interfaces;

namespace Mediator.Entidades;

public class Componente
{
    public IMediator Mediator { get; set; }

    public Componente(IMediator mediator = null)
    {
        Mediator = mediator;
    }
}
