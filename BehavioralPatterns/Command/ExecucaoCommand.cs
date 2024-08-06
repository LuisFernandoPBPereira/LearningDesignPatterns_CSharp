using Command.Entidades;

namespace Command;

public static class ExecucaoCommand
{
    public static void ExecutarFilaDePedidosUseCase()
    {
        var fila = new FilaDeTrabalho();
        var pedido1 = new Pedido("cliente 1", 100);
        var pedido2 = new Pedido("cliente 2", 100);

        fila.Adiciona(new PagaPedido(pedido1));
        fila.Adiciona(new PagaPedido(pedido2));
        
        fila.Adiciona(new FinalizaPedido(pedido1));
        fila.Adiciona(new FinalizaPedido(pedido2));

        fila.Processa();
    }
}
