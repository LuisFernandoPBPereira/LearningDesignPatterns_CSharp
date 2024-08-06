using Singleton.Entidades;

namespace Singleton.Singleton;

public class ConfiguracaoSingleton
{
    private Configuracao Configuracao = new Configuracao("Configuração1", "EXEMPLO_DE_CONFIGURACAO");

    public Configuracao Instancia()
    {
        return Configuracao;
    }
}
