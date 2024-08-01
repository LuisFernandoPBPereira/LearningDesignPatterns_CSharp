using TemplateMethod.Relatorio.Entidades;

namespace TemplateMethod.Relatorio.Interfaces;

public interface IRelatorio
{
    public void Emitir(Banco banco, List<Conta> contas, bool relatorioSimples);
}
