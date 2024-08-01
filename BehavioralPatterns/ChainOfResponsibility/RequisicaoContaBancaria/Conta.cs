namespace ChainOfResponsibility.RequisicaoContaBancaria;

public class Conta
{
    public string Nome { get; set; } = string.Empty;
    public double Saldo { get; set; }

    public Conta(){}

    public Conta(string nome, double saldo)
    {
        Nome = nome;
        Saldo = saldo;
    }
}
