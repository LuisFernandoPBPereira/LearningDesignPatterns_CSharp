﻿namespace Strategy.UseCases.Investimento;
public class CalculaInvestimento
{
    public double Calcular(Conta conta, IInvestimento investimento)
    {
        return investimento.Calcula(conta);
    }
}
