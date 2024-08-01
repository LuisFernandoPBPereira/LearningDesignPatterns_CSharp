using ChainOfResponsibility.UseCases.Imposto.Entidades;

namespace ChainOfResponsibility.UseCases.Imposto.Interfaces;

public interface IImposto
{
    double Calcula(Orcamento orcamento);
}
