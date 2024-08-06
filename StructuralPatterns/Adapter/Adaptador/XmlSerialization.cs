using System.Xml.Serialization;

namespace Adapter.Adaptador;

public class XmlSerialization
{
    public string GeraXml(object objeto)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(objeto.GetType());
        StringWriter stringWriter = new StringWriter();

        xmlSerializer.Serialize(stringWriter, objeto);
        string xml = stringWriter.ToString();

        return xml;
    }
}
