namespace Decorator.UseCases.FiltroContaBancaria.Entidades;

public abstract class Filtro
{
    public Filtro OutroFiltro { get; set; }

    public Filtro()
    {
        OutroFiltro = null;
    }

    public Filtro(Filtro outroFiltro)
    {
        OutroFiltro = outroFiltro;
    }

    public abstract IList<Conta> Filtra(IList<Conta> contas, IList<Conta> contasFiltradas);

    public IList<Conta> ExecutarOutroFiltro(IList<Conta> contas, IList<Conta> contasFiltradas)
    {
        if(OutroFiltro == null) return contasFiltradas;

        return OutroFiltro.Filtra(contas, contasFiltradas);
    }
}
