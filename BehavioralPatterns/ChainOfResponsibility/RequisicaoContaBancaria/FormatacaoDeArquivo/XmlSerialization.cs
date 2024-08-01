using System.Xml.Serialization;
using ChainOfResponsibility.RequisicaoContaBancaria.Enums;
using ChainOfResponsibility.RequisicaoContaBancaria.Interfaces;

namespace ChainOfResponsibility.RequisicaoContaBancaria.FormatacaoDeArquivo;

public class XmlSerialization : ISerializar
{
    public ISerializar Proximo { get; set; }
    public ISerializar? Serializar(Conta conta, Requisicao requisicao)
    {
        if(requisicao.Formato == E_Formato.XML)
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
