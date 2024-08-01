using ChainOfResponsibility.UseCases.Imposto.Entidades;

namespace ChainOfResponsibility.UseCases.Imposto.Interfaces;

public interface IDesconto
{
    double Desconto(Orcamento orcamento);
    IDesconto Proximo { get; set; }
}
