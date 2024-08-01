using ChainOfResponsibility.Imposto.Interfaces;

namespace ChainOfResponsibility.Imposto.Entidades;

public class SemDesconto : IDesconto
{
    public IDesconto Proximo { get; set; }

    public double Desconto(Orcamento orcamento) => 0;
}
