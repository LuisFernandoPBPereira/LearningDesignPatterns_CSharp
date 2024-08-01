﻿using TemplateMethod.Imposto;
using TemplateMethod.Imposto.Entidades;
using TemplateMethod.Imposto.Entidades.Impostos;
using TemplateMethod.Imposto.Interfaces;

namespace TemplateMethod;

public static class ExecucaoTemplateMethod
{
    public static void ExecutarImpostoUseCase()
    {
        IImposto icms = new ICMS();
        IImposto iss = new ISS();
        IImposto iccc = new ICCC();
        IImposto ikcv = new IKCV();
        IImposto icpp = new ICPP();

        Orcamento orcamento = new Orcamento(10000);

        CalculadoraDeImpostos calculadora = new CalculadoraDeImpostos();

        var impostoCalculado = calculadora.Calcula(orcamento, ikcv);

        Console.WriteLine(impostoCalculado);
    }
}
