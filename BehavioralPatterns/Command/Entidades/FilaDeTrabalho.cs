using Command.Interfaces;

namespace Command.Entidades;

public class FilaDeTrabalho
{
    public List<IComando> Comandos { get; private set; } = [];

    public void Adiciona(IComando comando)
    {
        Comandos.Add(comando);
    }

    public void Processa()
    {
        foreach (var comando in Comandos)
        {
            comando.Executa();
        }
    }
}
