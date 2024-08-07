using Composite.Entidades;

namespace Composite;

public static class ExecucaoComposite
{
    public static void ExecutarCaixaProdutoUseCase()
    {
        var cliente = new Cliente();
        var produto = new Produto();

        Console.WriteLine("Cliente: Eu tenho um simples componente:");
        cliente.Exemplo1(produto);

        var arvore = new CaixaComposite();
        
        var primeiraCaixa = new CaixaComposite();
        var segundaCaixa = new CaixaComposite();

        primeiraCaixa.Add(new Produto());
        segundaCaixa.Add(new Produto());
        
        arvore.Add(primeiraCaixa);
        arvore.Add(segundaCaixa);
        
        Console.WriteLine("Cliente: Agora eu tenho uma árvore composta:");
        cliente.Exemplo1(arvore);

        Console.Write("Cliente: Eu não preciso verificar as classes dos componentes nem mesmo quando estou manipulando a árvore:\n");
        cliente.Exemplo2(arvore, produto);
    }
}
