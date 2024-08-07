using System.Collections;

namespace Iterator;

public class ColecaoDePalavras : IteratorAggregate
{
    List<string> ListaDePalavras = new List<string>();
    public bool Direcao { get; set; }

    public ColecaoDePalavras()
    {
        Direcao = false;
    }

    public void InverterDirecaoDeIteracao() => Direcao = !Direcao;

    public List<string> GetItens() => ListaDePalavras;

    public void AdicionarItem(string item) => ListaDePalavras.Add(item);

    public override IEnumerator GetEnumerator() => new OrdenaColecaoIterator(this, Direcao);
}