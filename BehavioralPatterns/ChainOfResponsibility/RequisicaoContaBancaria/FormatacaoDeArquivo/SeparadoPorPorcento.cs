using System.Text;
using ChainOfResponsibility.RequisicaoContaBancaria.Enums;
using ChainOfResponsibility.RequisicaoContaBancaria.Interfaces;

namespace ChainOfResponsibility.RequisicaoContaBancaria.FormatacaoDeArquivo;

public class SeparadoPorPorcento : ISerializar
{
    public ISerializar Proximo { get; set; }
    public ISerializar? Serializar(Conta conta, Requisicao requisicao)
    {
        if(requisicao.Formato == E_Formato.PORCENTO)
        {
            StringBuilder arquivoPorPorcento = new StringBuilder();
            arquivoPorPorcento.AppendLine("Nome Titular%Saldo");
            arquivoPorPorcento.AppendLine($"{conta.Nome}%{conta.Saldo}");

            File.WriteAllText("Conta.txt", arquivoPorPorcento.ToString());

            return null;
        }

        return Proximo.Serializar(conta, requisicao);
    }
}
