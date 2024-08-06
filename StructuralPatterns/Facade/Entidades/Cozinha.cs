namespace Facade.Entidades;

public class Cozinha
{
    public void PreparaComida()
    {
        Console.WriteLine("Comida está sendo preparada");

        Thread.Sleep(2000);
        
        Console.WriteLine("Comida pronta\n");
    }
}
