using State.UseCases.ContaUseCase.Abstracao;

namespace State.UseCases.ContaUseCase.Entidades;

public class Conta
{
    public string NomeDoTitular { get; set; } = string.Empty;
    public double Saldo { get; set; }
    public EstadoConta EstadoConta { get; set; }
    
    public Conta(string nomeDoTitular, double saldo, EstadoConta estadoConta)
    {
        NomeDoTitular = nomeDoTitular;
        Saldo = saldo;
        EstadoConta = estadoConta;
    }

    public void Positivar()
    {
        EstadoConta.Positivar(this);
    }
    
    public void Negativar()
    {
        EstadoConta.Negativar(this);
    }

    public void Saque(double valor)
    {
        EstadoConta.EfetuaSaque(valor, this);
    }

    public void Deposito(double valor)
    {
        EstadoConta.EfetuaDeposito(valor, this);
    }
}
