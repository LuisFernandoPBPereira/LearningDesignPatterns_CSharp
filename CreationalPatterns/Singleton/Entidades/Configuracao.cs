namespace Singleton.Entidades;

public class Configuracao
{
    public string NomeDaConfiguracao { get; set; }
    public string ValorDaConfiguracao { get; set; }
    
    public Configuracao(string nomeDaConfiguracao, string valorDaConfiguracao)
    {
        NomeDaConfiguracao = nomeDaConfiguracao;
        ValorDaConfiguracao = valorDaConfiguracao;
    }
}
