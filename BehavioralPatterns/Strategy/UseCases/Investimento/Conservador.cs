namespace Strategy.UseCases.Investimento;

public class Conservador : IInvestimento
{
    public double Calcula(Conta conta)
    {
        return conta.Saldo * 1.008;
    }
}
