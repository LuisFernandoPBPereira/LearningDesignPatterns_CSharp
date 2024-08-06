using Command.Interfaces;

namespace Command.Entidades;

public class FinalizaPedido : IComando
{
    public Pedido Pedido { get; set; }
    public FinalizaPedido(Pedido pedido)
    {
        Pedido = pedido;
    }

    public void Executa()
    {
        Console.WriteLine($"Finalizando o pedido do cliente {Pedido.Cliente}");
        Pedido.Finaliza();
    }
}
