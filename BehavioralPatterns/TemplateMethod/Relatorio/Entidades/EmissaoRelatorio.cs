namespace TemplateMethod.Relatorio.Entidades;

public class EmissaoRelatorio : TemplateDeRelatiorio
{
    public override void EmitirRelatorioSimples(Banco banco, List<Conta> contas)
    {
        Console.WriteLine("========== Cabeçalho =========");
        Console.WriteLine($"Banco: {banco.Nome}");
        Console.WriteLine();
        Console.WriteLine();
        
        foreach (var conta in contas)
        {
            Console.WriteLine();
            Console.WriteLine($"Titular: {conta.NomeDoTitular}");
            Console.WriteLine($"Saldo: {conta.Saldo}");
            Console.WriteLine();
        }

        Console.WriteLine("==========  Rodapé   =========");
        Console.WriteLine($"Telefone: {banco.Telefone}");
    }

    public override void EmitirRelatorioComplexo(Banco banco, List<Conta> contas)
    {
        Console.WriteLine("========== Cabeçalho =========");
        Console.WriteLine($"Banco: {banco.Nome}");
        Console.WriteLine($"Endereço: {banco.Endereco}");
        Console.WriteLine($"Telefone: {banco.Telefone}");
        Console.WriteLine();
        Console.WriteLine();

        foreach (var conta in contas)
        {
            Console.WriteLine();
            Console.WriteLine($"Titular: {conta.NomeDoTitular}");
            Console.WriteLine($"Agência: {conta.Agencia}");
            Console.WriteLine($"Numero da Conta: {conta.Numero}");
            Console.WriteLine($"Saldo: {conta.Saldo}");
            Console.WriteLine();
        }

        Console.WriteLine("==========  Rodapé   =========");
        Console.WriteLine($"Telefone: {banco.Email}");
        Console.WriteLine($"Data Atual: {DateTime.Now.Date}");

    }
}
