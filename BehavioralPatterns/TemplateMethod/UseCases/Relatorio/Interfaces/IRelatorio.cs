using TemplateMethod.UseCases.Relatorio.Entidades;

namespace TemplateMethod.UseCases.Relatorio.Interfaces;

public interface IRelatorio
{
    public void Emitir(Banco banco, List<Conta> contas, bool relatorioSimples);
}
