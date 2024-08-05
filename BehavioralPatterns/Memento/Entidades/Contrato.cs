namespace Memento.Entidades;

public class Contrato
{
    public DateTime Data { get; set; }
    public string Cliente { get; set; } = string.Empty;
    public TipoContrato TipoContrato { get; set; }
    
    public Contrato(DateTime data, string cliente, TipoContrato tipoContrato)
    {
        Data = data;
        Cliente = cliente;
        TipoContrato = tipoContrato;
    }

    public void Avanca()
    {
        if (TipoContrato == TipoContrato.Novo) TipoContrato = TipoContrato.EmAndamento;
        else if (TipoContrato == TipoContrato.EmAndamento) TipoContrato = TipoContrato.Concluido;
        else if (TipoContrato == TipoContrato.Concluido) throw new Exception("Contrato já está concluído");
    }
}
