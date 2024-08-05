namespace Memento.Entidades;

public class HistoricoContrato
{
    public List<Contrato> Contratos { get; set; } = [];

    public void Adiciona(Contrato contrato)
    {
        Contratos.Add(new Contrato(contrato.Data, contrato.Cliente, contrato.TipoContrato));
    }

    public Contrato BuscarContrato(int indice)
    {
        return Contratos[indice];
    }
}
