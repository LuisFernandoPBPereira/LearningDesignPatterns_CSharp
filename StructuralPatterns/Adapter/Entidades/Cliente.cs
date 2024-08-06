namespace Adapter.Entidades;

public class Cliente
{
    public string Nome { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;
    public DateTime DataDeNascimento { get; set; }

    public Cliente() { }

    public Cliente(string nome, string endereco, DateTime dataDeNascimento)
    {
        Nome = nome;
        Endereco = endereco;
        DataDeNascimento = dataDeNascimento;
    }
}
