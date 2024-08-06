using Singleton.Singleton;

namespace Singleton;

public static class ExecucaoSingleton
{
    public static void ExecutarConfiguracaoUseCase()
    {
        var configuracao = new ConfiguracaoSingleton().Instancia();

        Console.WriteLine(configuracao.NomeDaConfiguracao);
        Console.WriteLine(configuracao.ValorDaConfiguracao);
    }
}
