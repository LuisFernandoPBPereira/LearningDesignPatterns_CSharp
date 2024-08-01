using State.Estados;
using State.Interfaces;

namespace State.Entidades;

public class Orcamento
{
    public IEstadoOrcamento EstadoAtual { get; set; }
    public double Valor { get; set; }
    public IList<Item> Itens { get; private set; }

    public Orcamento(double valor)
    {
        EstadoAtual = new EmAprovacao();
        Valor = valor;
        Itens = new List<Item>();
    }

    public void AdicionarItem(Item item)
    {
        Itens.Add(item);
    }

    public void AplicaDescontoExtra()
    {
        EstadoAtual.AplicaDescontoExtra(this);
    }

    public void Aprova()
    {
        EstadoAtual.Aprova(this);
    }

    public void Finaliza()
    {
        EstadoAtual.Finaliza(this);
    }

    public void Reprova()
    {
        EstadoAtual.Reprova(this);
    }
}
