using ChainOfResponsibility.UseCases.Imposto.Interfaces;

namespace ChainOfResponsibility.UseCases.Imposto.Entidades;

public class SemDesconto : IDesconto
{
    public IDesconto Proximo { get; set; }

    public double Desconto(Orcamento orcamento) => 0;
}
