namespace Iterator;

public class OrdenaColecaoIterator : AbstracaoIterator
{
    private ColecaoDePalavras _colecaoDePalavras;

    private int _posicao = -1;

    private bool _reverso = false;

    public OrdenaColecaoIterator(ColecaoDePalavras colecao, bool reverso = false)
    {
        _colecaoDePalavras = colecao;
        _reverso = reverso;

        if (reverso)
        {
            _posicao = colecao.GetItens().Count;
        }
    }

    public override object Current() => _colecaoDePalavras.GetItens()[_posicao];

    public override int Key() => _posicao;

    public override bool MoveNext()
    {
        int proximaPosicaoReversa = -1;
        int proximaPosicao = 1;

        int atualizaPosicao = _posicao + (_reverso ? proximaPosicaoReversa : proximaPosicao);

        if (atualizaPosicao >= 0 && atualizaPosicao < _colecaoDePalavras.GetItens().Count)
        {
            _posicao = atualizaPosicao;
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void Reset()
    {
        _posicao = _reverso ? _colecaoDePalavras.GetItens().Count - 1 : 0;
    }
}
