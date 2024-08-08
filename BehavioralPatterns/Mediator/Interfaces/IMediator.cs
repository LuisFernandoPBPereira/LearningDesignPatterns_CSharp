namespace Mediator.Interfaces;

public interface IMediator
{
    public void Notificar(object sender, string evento);
}
