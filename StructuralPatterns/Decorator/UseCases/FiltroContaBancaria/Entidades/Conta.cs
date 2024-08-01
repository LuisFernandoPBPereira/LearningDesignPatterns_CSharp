namespace Decorator.UseCases.FiltroContaBancaria.Entidades;

public class Conta
{
    public string NomeDoTitular { get; set; } = string.Empty;
    public DateTime DataAbertura { get; set; }
    public double Saldo { get; set; }

    public Conta(string nomeDoTitular, DateTime dataAbertura, double saldo)
    {
        NomeDoTitular = nomeDoTitular;
        DataAbertura = dataAbertura;
        Saldo = saldo;
    }
}