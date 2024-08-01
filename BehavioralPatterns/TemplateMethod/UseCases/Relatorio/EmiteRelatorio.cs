using TemplateMethod.UseCases.Relatorio.Entidades;
using TemplateMethod.UseCases.Relatorio.Interfaces;

namespace TemplateMethod.UseCases.Relatorio;

public class EmiteRelatorio
{
    public void Executar(Banco banco, List<Conta> contas, IRelatorio relatorio, bool relatorioSimples)
    {
        relatorio.Emitir(banco, contas, relatorioSimples);
    }
}
