using ChainOfResponsibility.RequisicaoContaBancaria.Enums;
using ChainOfResponsibility.RequisicaoContaBancaria.FormatacaoDeArquivo;
using ChainOfResponsibility.RequisicaoContaBancaria.Interfaces;

namespace ChainOfResponsibility.RequisicaoContaBancaria;

public class Requisicao
{
    public E_Formato Formato { get; set; }

    public Requisicao(E_Formato formato)
    {
        Formato = formato;
    }

    public ISerializar Executar(Conta conta)
    {
        var csv = new CsvSerialization();
        var xml = new XmlSerialization();
        var porcento = new SeparadoPorPorcento();

        csv.Proximo = xml;
        xml.Proximo = porcento;

        return csv.Serializar(conta, this)!;
    }
}
