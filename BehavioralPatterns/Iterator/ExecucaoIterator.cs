namespace Iterator;

public static class ExecucaoIterator
{
    public static void ExecutarUseCase()
    {
        var colecao = new ColecaoDePalavras();
        colecao.AdicionarItem("Primeiro");
        colecao.AdicionarItem("Segundo");
        colecao.AdicionarItem("Terceiro");

        Console.WriteLine("Iteração normal:");

        foreach (var elemento in colecao)
        {
            Console.WriteLine(elemento);
        }

        Console.WriteLine("\nIteração Reversa:");

        colecao.InverterDirecaoDeIteracao();

        foreach (var elemento in colecao)
        {
            Console.WriteLine(elemento);
        }
    }
}
