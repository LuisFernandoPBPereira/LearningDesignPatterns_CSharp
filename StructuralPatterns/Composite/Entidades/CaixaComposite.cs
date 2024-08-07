using Composite.Abstracao;

namespace Composite.Entidades;

public class CaixaComposite : Componente
{
    protected List<Componente> listaDeComponentes = new List<Componente>();

    public override void Add(Componente componente)
    {
        listaDeComponentes.Add(componente);
    }

    public override void Remove(Componente componente)
    {
        listaDeComponentes.Remove(componente);
    }

    public override string Operacao()
    {
        int listCount = 0;

        string resultado = "Caixa(";

        foreach (Componente componente in listaDeComponentes)
        {
            resultado += componente.Operacao();

            if (listCount != listaDeComponentes.Count - 1)
            {
                resultado += "+";
            }

            listCount++;
        }

        return resultado + ")";
    }
}
