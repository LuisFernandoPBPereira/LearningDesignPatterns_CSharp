namespace Facade.Entidades;

public class Entrega
{
    public void RealizaEntrega()
    {
        Console.WriteLine("Enviando pedido...");

        Thread.Sleep(2000);

        Console.WriteLine("Saiu para entrega");
    }
}
