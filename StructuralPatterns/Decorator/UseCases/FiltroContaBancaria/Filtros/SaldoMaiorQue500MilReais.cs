using Decorator.UseCases.FiltroContaBancaria.Entidades;

namespace Decorator.UseCases.FiltroContaBancaria.Filtros;

public class SaldoMaiorQue500MilReais : Filtro
{
    public SaldoMaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro){}
    public SaldoMaiorQue500MilReais() { }


    public override IList<Conta> Filtra(IList<Conta> contas, IList<Conta> contasFiltradas)
    {
        foreach (var conta in contas)
        {
            if(conta.Saldo > 500000) contasFiltradas.Add(conta);
        }

        return ExecutarOutroFiltro(contas, contasFiltradas);
    }
}
