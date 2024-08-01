using Decorator.UseCases.FiltroContaBancaria.Entidades;

namespace Decorator.UseCases.FiltroContaBancaria.Filtros;

public class ContaAbertaNoMesRecorrente : Filtro
{
    public ContaAbertaNoMesRecorrente(Filtro outroFiltro) : base(outroFiltro){}
    public ContaAbertaNoMesRecorrente() : base(){}

    public override IList<Conta> Filtra(IList<Conta> contas, IList<Conta> contasFiltradas)
    {
        foreach (var conta in contas)
        {
            if(conta.DataAbertura.Date.Month == DateTime.Now.Month)
                contasFiltradas.Add(conta);
        }

        return ExecutarOutroFiltro(contas, contasFiltradas);
    }
}
