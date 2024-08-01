using TemplateMethod.Imposto.Entidades;

namespace TemplateMethod.Imposto.Interfaces;

public interface IImposto
{
    double Calcula(Orcamento orcamento);
}
