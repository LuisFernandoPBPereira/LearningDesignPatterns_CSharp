using AbstractFactory.Entidades;

namespace AbstractFactory;

public static class ExecucaoAbstractMethod
{
    public static void ExecutarFabricaDeMoveisUseCase()
    {
        var fabricaDecorativa = new FabricaDeMoveisDecorativos();
        var fabricaModerna = new FabricaDeMoveisModerna();
        var fabricaVitoriana = new FabricaDeMoveisVitoriana();


        var sofaDecorativo = fabricaDecorativa.CriaSofa();
        var cadeiraDecorativa = fabricaDecorativa.CriaCadeira();
        var mesaDecorativa = fabricaDecorativa.CriaMesa();

        var sofaModerno = fabricaModerna.CriaSofa();
        var cadeiraModerna = fabricaModerna.CriaCadeira();
        var mesaModerna = fabricaModerna.CriaMesa();

        var sofaVitoriano = fabricaVitoriana.CriaSofa();
        var cadeiraVitoriana = fabricaVitoriana.CriaCadeira();
        var mesaVitoriana = fabricaVitoriana.CriaMesa();

        Console.WriteLine(sofaDecorativo);
        Console.WriteLine(sofaVitoriano);
        Console.WriteLine(sofaModerno);
        Console.WriteLine();
        Console.WriteLine(cadeiraDecorativa);
        Console.WriteLine(cadeiraVitoriana);
        Console.WriteLine(cadeiraModerna);
        Console.WriteLine();
        Console.WriteLine(mesaDecorativa);
        Console.WriteLine(mesaVitoriana);
        Console.WriteLine(mesaModerna);
    }
}
