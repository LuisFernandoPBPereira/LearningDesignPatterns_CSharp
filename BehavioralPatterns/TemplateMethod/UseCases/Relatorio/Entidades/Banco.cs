namespace TemplateMethod.UseCases.Relatorio.Entidades;

public class Banco
{
    public string Nome { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public Banco(string nome, string endereco, string telefone, string email)
    {
        Nome = nome;
        Endereco = endereco;
        Telefone = telefone;
        Email = email;
    }
}
