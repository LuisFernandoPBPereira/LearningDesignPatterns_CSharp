using Decorator.UseCases.FiltroContaBancaria.Entidades;

namespace Decorator.UseCases.FiltroContaBancaria.Filtros;

public class SaldoMenorQue100Reais : Filtro
{
    public SaldoMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro){}
    public SaldoMenorQue100Reais(){}

    public override IList<Conta> Filtra(IList<Conta> contas, IList<Conta> contasFiltradas)
    {
        foreach (var conta in contas)
        {
            if(conta.Saldo < 100) contasFiltradas.Add(conta);
        }

        return ExecutarOutroFiltro(contas,contasFiltradas);
    }
}
