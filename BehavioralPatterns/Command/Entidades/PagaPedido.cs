using Command.Interfaces;

namespace Command.Entidades;

public class PagaPedido : IComando
{
    public Pedido Pedido { get; set; }
    public PagaPedido(Pedido pedido)
    {
        Pedido = pedido;
    }
    public void Executa()
    {
        Console.WriteLine($"Pagando o pedido do cliente {Pedido.Cliente}");
        Pedido.Paga();
    }
}
