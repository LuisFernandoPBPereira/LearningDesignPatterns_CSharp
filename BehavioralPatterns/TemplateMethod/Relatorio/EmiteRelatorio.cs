using TemplateMethod.Relatorio.Entidades;
using TemplateMethod.Relatorio.Interfaces;

namespace TemplateMethod.Relatorio;

public class EmiteRelatorio
{
    public void Executar(Banco banco, List<Conta> contas, IRelatorio relatorio, bool relatorioSimples)
    {
        relatorio.Emitir(banco, contas, relatorioSimples);
    }
}
