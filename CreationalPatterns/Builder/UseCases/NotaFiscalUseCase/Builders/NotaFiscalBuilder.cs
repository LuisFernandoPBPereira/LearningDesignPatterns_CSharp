using Builder.UseCases.NotaFiscalUseCase.Entidades;

namespace Builder.UseCases.NotaFiscalUseCase.Builders;

public class NotaFiscalBuilder
{
    private string RazaoSocial { get; set; } = string.Empty;
    private string Cnpj { get; set; } = string.Empty;
    private DateTime DataEmissao { get; set; }
    private double ValorBruto { get; set; }
    private double Impostos { get; set; }
    private List<ItemDaNota> Itens { get; set; } = [];
    private string Observacao { get; set; } = string.Empty;

    public NotaFiscal Build()
    {
        return new NotaFiscal(RazaoSocial, Cnpj, DataEmissao, ValorBruto, Impostos, Itens, Observacao);
    }

    public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
    {
        RazaoSocial = razaoSocial;
        return this;
    }

    public NotaFiscalBuilder ComCnpj(string cnpj)
    {
        Cnpj = cnpj;
        return this;
    }

    public NotaFiscalBuilder NaDataAtual()
    {
        DataEmissao = DateTime.Now;
        return this;
    }

    public NotaFiscalBuilder ComItem(ItemDaNota item)
    {
        Itens.Add(item);
        ValorBruto += item.Valor;
        Impostos += item.Valor * 0.05;

        return this;
    }

    public NotaFiscalBuilder ComObservacao(string observacao)
    {
        Observacao = observacao;

        return this;
    }
}
