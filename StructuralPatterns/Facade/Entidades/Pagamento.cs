namespace Facade.Entidades;

public class Pagamento
{
    public void RealizaPagamento()
    {
        Console.WriteLine("Processando pagamento...");

        Thread.Sleep(2000);

        Console.WriteLine("Transação Autorizada\n");
    }
}
