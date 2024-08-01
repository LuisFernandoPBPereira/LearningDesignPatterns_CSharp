using TemplateMethod.UseCases.Imposto.Entidades;

namespace TemplateMethod.UseCases.Imposto.Interfaces;

public interface IImposto
{
    double Calcula(Orcamento orcamento);
}
