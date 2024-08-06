using Facade.Entidades;

namespace Facade.Facades;

public class RestauranteFacade
{
    private Cozinha Cozinha { get; set; }
    private Pagamento Pagamento { get; set; }
    private Entrega Entrega { get; set; }

    public RestauranteFacade()
    {
        Cozinha = new Cozinha();
        Pagamento = new Pagamento();
        Entrega = new Entrega();
    }

    public void RealizaPedido()
    {
        Pagamento.RealizaPagamento();
        Cozinha.PreparaComida();
        Entrega.RealizaEntrega();
    }
}
