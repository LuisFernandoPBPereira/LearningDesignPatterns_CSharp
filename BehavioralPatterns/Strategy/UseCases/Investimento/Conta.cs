﻿namespace Strategy.UseCases.Investimento;

public class Conta
{
    public double Saldo { get; set; }

    public Conta(double saldo)
    {
        Saldo = saldo;
    }
}