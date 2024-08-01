using ChainOfResponsibility.UseCases.RequisicaoContaBancaria;

namespace ChainOfResponsibility.UseCases.RequisicaoContaBancaria.Interfaces;

public interface ISerializar
{
    public ISerializar Proximo { get; set; }
    public ISerializar? Serializar(Conta conta, Requisicao requisicao);
}
