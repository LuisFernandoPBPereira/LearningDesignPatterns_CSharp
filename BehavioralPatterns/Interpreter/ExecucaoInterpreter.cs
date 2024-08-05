using Interpreter.Entidades;
using System.Linq.Expressions;

namespace Interpreter;

public static class ExecucaoInterpreter
{
    public static void ExecutarExpressaoUseCase()
    {
        var expressaoEsquerda = new Soma(new Numero(1), new Numero(10));
        var expressaoDireita = new Subtracao(new Numero(20), new Numero(10));

        var soma = new Soma(expressaoEsquerda, expressaoDireita);

        Console.WriteLine(soma.Avalia());

        #region System.Linq.Expression: Intepreter

        Expression somaExpression = Expression.Add(Expression.Constant(1), Expression.Constant(10));
        Func<int> funcao = Expression.Lambda<Func<int>>(somaExpression).Compile();

        Console.WriteLine(funcao());

        #endregion

    }
}
