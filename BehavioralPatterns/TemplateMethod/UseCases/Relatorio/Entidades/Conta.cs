namespace TemplateMethod.UseCases.Relatorio.Entidades;

public class Conta
{
    public string NomeDoTitular { get; set; } = string.Empty;
    public string Agencia { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty;
    public double Saldo { get; set; }

    public Conta(string nomeDoTitular, string agencia, string numero, double saldo)
    {
        NomeDoTitular = nomeDoTitular;
        Agencia = agencia;
        Numero = numero;
        Saldo = saldo;
    }
}
