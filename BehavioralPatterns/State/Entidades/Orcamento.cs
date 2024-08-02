using State.Abstracao;
using State.Estados;

namespace State.Entidades;

public class Orcamento
{
    public EstadoOrcamento EstadoAtual { get; set; }
    public double Valor { get; set; }
    public IList<Item> Itens { get; private set; }
    public int DescontosEmAprovacao { get; set; }
    public int DescontosAprovado { get; set; }


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
        if (DescontosAprovado == 1 || DescontosEmAprovacao == 1)
            throw new Exception("Não é possível aplicar o mesmo desconto 2 vezes");

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
