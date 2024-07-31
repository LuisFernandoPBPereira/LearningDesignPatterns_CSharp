using ChainOfResponsibility.Imposto.Entidades;

namespace ChainOfResponsibility.Imposto.Interfaces;

public interface IImposto
{
    double Calcula(Orcamento orcamento);
}
