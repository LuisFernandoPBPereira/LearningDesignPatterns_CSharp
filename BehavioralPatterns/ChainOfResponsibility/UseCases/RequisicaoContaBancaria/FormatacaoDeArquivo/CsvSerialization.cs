using System.Text;
using ChainOfResponsibility.UseCases.RequisicaoContaBancaria;
using ChainOfResponsibility.UseCases.RequisicaoContaBancaria.Enums;
using ChainOfResponsibility.UseCases.RequisicaoContaBancaria.Interfaces;

namespace ChainOfResponsibility.UseCases.RequisicaoContaBancaria.FormatacaoDeArquivo;

public class CsvSerialization : ISerializar
{
    public ISerializar Proximo { get; set; }
    public ISerializar? Serializar(Conta conta, Requisicao requisicao)
    {
        if (requisicao.Formato == E_Formato.CSV)
        {
            StringBuilder csv = new StringBuilder();
            csv.AppendLine("Nome Titular,Saldo");
            csv.AppendLine($"{conta.Nome},{conta.Saldo}");

            File.WriteAllText("Conta.csv", csv.ToString());

            return null;
        }

        return Proximo.Serializar(conta, requisicao);
    }
}
