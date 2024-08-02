﻿using Observer.UseCases.NotaFiscalUseCase.Entidades;
using Observer.UseCases.NotaFiscalUseCase.Interfaces;

namespace Observer.UseCases.NotaFiscalUseCase.Publishers;

public class NotaFiscalBuilder
{
    private string RazaoSocial { get; set; } = string.Empty;
    private string Cnpj { get; set; } = string.Empty;
    private DateTime? DataEmissao { get; set; }
    private double ValorBruto { get; set; }
    private double Impostos { get; set; }
    private List<ItemDaNota> Itens { get; set; } = [];
    private string Observacao { get; set; } = string.Empty;
    private List<IAcaoNotaFiscalGerada> Acoes{ get; set; } = [];

    public NotaFiscal Build()
    {
        var notaFiscal = new NotaFiscal(RazaoSocial, Cnpj, DataEmissao, ValorBruto, Impostos, Itens, Observacao);

        foreach (var acao in Acoes)
        {
            acao.Executar(notaFiscal);
        }

        return notaFiscal;
    }

    public void AdicionaAcao(IAcaoNotaFiscalGerada novaAcao)
    {
        Acoes.Add(novaAcao);
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

    public NotaFiscalBuilder NaData(string data)
    {

        DateTime dataConvertida;

        var dataValida = DateTime.TryParse(data, out dataConvertida);

        if (dataValida is false)
            throw new Exception("Data está no formato incorreto");

        if (data.Equals(string.Empty))
            throw new Exception("Data está no formato incorreto");

        DataEmissao = dataConvertida;

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