namespace Builder.UseCases.NotaFiscalUseCase.Entidades;

public class NotaFiscal
{
    public NotaFiscal(
        string razaoSocial,
        string cnpj,
        DateTime? dataEmissao,
        double valorBruto,
        double impostos,
        List<ItemDaNota> itens,
        string observacao)
    {
        RazaoSocial = razaoSocial;
        Cnpj = cnpj;
        DataEmissao = dataEmissao ?? DateTime.Now;
        ValorBruto = valorBruto;
        Impostos = impostos;
        Itens = itens;
        Observacao = observacao;
    }

    public string RazaoSocial { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    public DateTime DataEmissao { get; set; }
    public double ValorBruto { get; set; }
    public double Impostos { get; set; }
    public List<ItemDaNota> Itens { get; set; }
    public string Observacao { get; set; }

    public void ExibirNota()
    {
        Console.WriteLine("====== Nota Fiscal ======");
        Console.WriteLine();
        Console.WriteLine(RazaoSocial);
        Console.WriteLine(Cnpj);
        Console.WriteLine(DataEmissao);
        Console.WriteLine(ValorBruto);
        Console.WriteLine(Impostos);

        MostrarItensDaNota();
        
        Console.WriteLine(Observacao);
        Console.WriteLine();
        Console.WriteLine("=========================");
    }

    private void MostrarItensDaNota()
    {
        Console.WriteLine();
        Console.WriteLine("===== Itens da Nota =====");
        
        foreach (var item in Itens)
        {
            Console.WriteLine(item.Nome);
            Console.WriteLine(item.Valor);
            Console.WriteLine();
        }
        Console.WriteLine("=========================");
        Console.WriteLine();
    }
}
