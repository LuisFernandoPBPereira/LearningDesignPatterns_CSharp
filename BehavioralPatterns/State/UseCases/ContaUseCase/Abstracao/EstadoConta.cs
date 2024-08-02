using State.UseCases.ContaUseCase.Entidades;
using State.UseCases.ContaUseCase.Estados;

namespace State.UseCases.ContaUseCase.Abstracao;

public abstract class EstadoConta
{
    public void VerificaSaldo(Conta conta)
    {
        if(conta.Saldo < 0)
            conta.EstadoConta = new Negativo();

        if (conta.Saldo >= 0)
            conta.EstadoConta = new Positivo();
    }

    public abstract void EfetuaSaque(double valor, Conta conta);

    public abstract void EfetuaDeposito(double valor, Conta conta);

    public abstract void Positivar(Conta conta);

    public abstract void Negativar(Conta conta);

}
