using TemplateMethod.Imposto;
using TemplateMethod.Imposto.Entidades;
using TemplateMethod.Imposto.Entidades.Impostos;
using TemplateMethod.Imposto.Interfaces;
using TemplateMethod.Relatorio;
using TemplateMethod.Relatorio.Entidades;

namespace TemplateMethod;

public static class ExecucaoTemplateMethod
{
    public static void ExecutarImpostoUseCase()
    {
        IImposto icms = new ICMS();
        IImposto iss = new ISS();
        IImposto iccc = new ICCC();
        IImposto ikcv = new IKCV();
        IImposto icpp = new ICPP();

        Orcamento orcamento = new Orcamento(10000);

        CalculadoraDeImpostos calculadora = new CalculadoraDeImpostos();

        var impostoCalculado = calculadora.Calcula(orcamento, ikcv);

        Console.WriteLine(impostoCalculado);
    }
    
    public static void ExecutarImpostoIHITUseCase()
    {
        IImposto ihit = new IHIT();

        Orcamento orcamento = new Orcamento(10000);
        orcamento.AdicionarItem(new Item("Xbox", 2000));
        orcamento.AdicionarItem(new Item("Xbox", 2000));

        CalculadoraDeImpostos calculadora = new CalculadoraDeImpostos();

        var impostoCalculado = calculadora.Calcula(orcamento, ihit);

        Console.WriteLine(impostoCalculado);
    }

    public static void ExecutarRelatorioUseCase()
    {
        var banco = new Banco("banco tal", "endereço tal", "1191234-5678", "email@exemplo.com");

        var listaContas = new List<Conta>()
        {
            new Conta("titular1", "0000", "00000000", 20000),
            new Conta("titular2", "0000", "00000000", 20000),
            new Conta("titular3", "0000", "00000000", 20000),
            new Conta("titular4", "0000", "00000000", 20000),
            new Conta("titular5", "0000", "00000000", 20000),
        };

        var emitirRelatorio = new EmiteRelatorio();
        var relatorio = new EmissaoRelatorio();

        emitirRelatorio.Executar(banco, listaContas, relatorio, relatorioSimples: false);
    }
}
