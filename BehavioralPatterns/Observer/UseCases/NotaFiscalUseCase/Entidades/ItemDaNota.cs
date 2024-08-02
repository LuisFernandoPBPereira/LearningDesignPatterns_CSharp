namespace Observer.UseCases.NotaFiscalUseCase.Entidades;

public class ItemDaNota
{
    public string Nome { get; set; } = string.Empty;
    public double Valor { get; set; }

    public ItemDaNota(string nome, double valor)
    {
        Nome = nome;
        Valor = valor;
    }
}
