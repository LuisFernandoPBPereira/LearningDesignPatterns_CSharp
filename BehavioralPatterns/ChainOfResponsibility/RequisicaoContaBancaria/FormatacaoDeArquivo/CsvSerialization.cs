using System.Text;
using ChainOfResponsibility.RequisicaoContaBancaria.Enums;
using ChainOfResponsibility.RequisicaoContaBancaria.Interfaces;

namespace ChainOfResponsibility.RequisicaoContaBancaria.FormatacaoDeArquivo;

public class CsvSerialization : ISerializar
{
    public ISerializar Proximo { get; set; }
    public ISerializar? Serializar(Conta conta, Requisicao requisicao)
    {
        if(requisicao.Formato == E_Formato.CSV)
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
