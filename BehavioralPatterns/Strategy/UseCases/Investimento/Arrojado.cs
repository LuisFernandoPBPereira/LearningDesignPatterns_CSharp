namespace Strategy.UseCases.Investimento;

public class Arrojado : IInvestimento
{
    public double Calcula(Conta conta)
    {
        int porcentagem = new Random().Next(101);

        if (porcentagem <= 20)
            return conta.Saldo * 1.05;

        if (porcentagem <= 30)
            return conta.Saldo * 1.03;

        return conta.Saldo * 1.003;
    }
}
