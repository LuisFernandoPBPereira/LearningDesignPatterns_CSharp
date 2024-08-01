using TemplateMethod.UseCases.Relatorio.Entidades;
using TemplateMethod.UseCases.Relatorio.Interfaces;

namespace TemplateMethod.UseCases.Relatorio;

public abstract class TemplateDeRelatiorio : IRelatorio
{
    public void Emitir(Banco banco, List<Conta> contas, bool relatorioSimples)
    {
        if (relatorioSimples)
        {
            EmitirRelatorioSimples(banco, contas);
            return;
        }

        EmitirRelatorioComplexo(banco, contas);
    }
    public abstract void EmitirRelatorioSimples(Banco banco, List<Conta> contas);
    public abstract void EmitirRelatorioComplexo(Banco banco, List<Conta> contas);

}
