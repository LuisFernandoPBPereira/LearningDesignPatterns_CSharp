using Adapter.Adaptador;
using Adapter.Entidades;

namespace Adapter;

public static class ExecucaoAdapter
{
    public static void ExecutarSerializacaoXmlUseCase()
    {
        var cliente = new Cliente("Cliente", "Rua tal", new DateTime(2000, 01, 01));

        var xml = new XmlSerialization();

        Console.WriteLine(xml.GeraXml(cliente));
    }
}
