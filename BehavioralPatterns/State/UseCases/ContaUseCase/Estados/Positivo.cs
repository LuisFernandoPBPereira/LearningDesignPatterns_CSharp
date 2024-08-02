using State.UseCases.ContaUseCase.Abstracao;
using State.UseCases.ContaUseCase.Entidades;

namespace State.UseCases.ContaUseCase.Estados;

public class Positivo : EstadoConta
{
    public override void EfetuaDeposito(double valor, Conta conta)
    {
        conta.Saldo += valor * 0.98;
    }

    public override void EfetuaSaque(double valor, Conta conta)
    {
        if(valor > conta.Saldo)
            throw new Exception("Saldo insuficiente");

        conta.Saldo -= valor;
    }

    public override void Negativar(Conta conta)
    {
        VerificaSaldo(conta);
    }

    public override void Positivar(Conta conta)
    {
        VerificaSaldo(conta);
    }
}
