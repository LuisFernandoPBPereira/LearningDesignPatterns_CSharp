namespace Strategy.UseCases.Imposto;

public class CalculadoraDeImpostos
{
    public double Calcula(Orcamento orcamento, IImposto imposto)
    {
        return imposto.Calcula(orcamento);
    }
}
