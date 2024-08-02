using State.UseCases.ContaUseCase.Abstracao;
using State.UseCases.ContaUseCase.Entidades;

namespace State.UseCases.ContaUseCase.Estados;

public class Negativo : EstadoConta
{
    public override void EfetuaDeposito(double valor, Conta conta)
    {
        conta.Saldo += valor * 0.95;
    }

    public override void EfetuaSaque(double valor, Conta conta)
    {
        throw new Exception("Não foi possível realizar o saque, você está negativado");
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
