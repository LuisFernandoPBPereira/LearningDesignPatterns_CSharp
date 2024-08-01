using ChainOfResponsibility.Imposto.Entidades;

namespace ChainOfResponsibility.Imposto.Interfaces;

public interface IDesconto
{
    double Desconto(Orcamento orcamento);
    IDesconto Proximo { get; set; }
}
