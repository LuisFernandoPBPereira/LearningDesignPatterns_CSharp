namespace Strategy.Investimento;

public class Moderado : IInvestimento
{
    public double Calcula(Conta conta)
    {
        bool maiorPorcentagem = new Random().Next(101) > 50;

        return maiorPorcentagem ? conta.Saldo * 1.025 : conta.Saldo * 1.007;
    }
}
