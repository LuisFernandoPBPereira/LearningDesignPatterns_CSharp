using Bridge.Entidades;

namespace Bridge;

public static class ExecucaoBridge
{
    public static void ExecutarEnviadorDeMensagemUseCase()
    {
        var mensagemCliente = new MensagemCliente("Luis");
        var mensagemAdministrativa = new MensagemAdministrativa("Luis");

        var enviadorEmail = new EnviaPorEmail();
        var enviadorSMS = new EnviaPorSMS();

        mensagemCliente.Enviador = enviadorEmail;
        mensagemCliente.Envia();
        
        mensagemCliente.Enviador = enviadorSMS;
        mensagemCliente.Envia();
        
        mensagemAdministrativa.Enviador = enviadorEmail;
        mensagemAdministrativa.Envia();
        
        mensagemAdministrativa.Enviador = enviadorSMS;
        mensagemAdministrativa.Envia();


    }
}
