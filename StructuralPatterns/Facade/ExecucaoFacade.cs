using Facade.Facades;

namespace Facade;

public static class ExecucaoFacade
{
    public static void ExecutarRestauranteUseCase()
    {
        new RestauranteFacade().RealizaPedido();
    }
}
