using Visitor.Entidades;

namespace Visitor;

public static class ExecucaoVisitor
{
    public static void ExecutarExpressaoUseCase()
    {
        var impressora = new ImpressoraVisitor();

        var expressaoEsquerda = new Soma(new Numero(1), new Numero(10));
        var expressaoDireita = new Subtracao(new Numero(20), new Numero(10));

        var soma = new Soma(expressaoEsquerda, expressaoDireita);

        soma.Aceita(impressora);

        Console.Write($" = {soma.Avalia()}");
    }
}
