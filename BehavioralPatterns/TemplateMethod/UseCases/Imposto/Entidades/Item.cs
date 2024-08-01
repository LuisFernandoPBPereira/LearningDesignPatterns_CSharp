namespace TemplateMethod.UseCases.Imposto.Entidades;

public class Item
{
    public string Nome { get; private set; } = string.Empty;
    public double Valor { get; private set; }

    public Item(string nome, double valor)
    {
        Nome = nome;
        Valor = valor;
    }
}
