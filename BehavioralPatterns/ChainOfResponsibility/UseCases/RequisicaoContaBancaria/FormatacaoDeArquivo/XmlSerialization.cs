using System.Xml.Serialization;
using ChainOfResponsibility.UseCases.RequisicaoContaBancaria;
using ChainOfResponsibility.UseCases.RequisicaoContaBancaria.Enums;
using ChainOfResponsibility.UseCases.RequisicaoContaBancaria.Interfaces;

namespace ChainOfResponsibility.UseCases.RequisicaoContaBancaria.FormatacaoDeArquivo;

public class XmlSerialization : ISerializar
{
    public ISerializar Proximo { get; set; }
    public ISerializar? Serializar(Conta conta, Requisicao requisicao)
    {
        if (requisicao.Formato == E_Formato.XML)
        {
            var xmlSerializer = new XmlSerializer(conta.GetType());

            using (FileStream fs = new FileStream("Conta.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, conta);
            }

            return null;
        }

        return Proximo.Serializar(conta, requisicao);
    }
}
