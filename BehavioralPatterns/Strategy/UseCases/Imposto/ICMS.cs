﻿namespace Strategy.UseCases.Imposto;

public class ICMS : IImposto
{
    public double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.1;
    }
}