using Mediator.Interfaces;

namespace Mediator.Entidades;

public class ImplementacaoMediador : IMediator
{
    public TextBox TextBox1 { get; set; }
    public TextBox TextBox2 { get; set; }
    public Botao BotaoSoma { get; set; }
    public Botao BotaoSubtracao { get; set; }
    public Botao BotaoMultiplicacao { get; set; }
    public Botao BotaoDivisao { get; set; }
    public ImplementacaoMediador(
        TextBox textBox1,
        TextBox textBox2,
        Botao addButton,
        Botao subtractButton,
        Botao multiplyButton,
        Botao divideButton)
    {
        TextBox1 = textBox1;
        TextBox1.Mediator = this;

        TextBox2 = textBox2;
        TextBox2.Mediator = this;

        BotaoSoma = addButton;
        BotaoSoma.Mediator = this;

        BotaoSubtracao = subtractButton;
        BotaoSubtracao.Mediator = this;

        BotaoMultiplicacao = multiplyButton;
        BotaoMultiplicacao.Mediator = this;

        BotaoDivisao = divideButton;
        BotaoDivisao.Mediator = this;
    }
    public void Notificar(object sender, string evento)
    {
        if (evento.Equals("Click"))
        {
            if (sender == BotaoSoma || sender == BotaoSubtracao || 
                sender == BotaoMultiplicacao || sender == BotaoDivisao)
            {
                TextBox1.Habilitar();
                TextBox2.Habilitar();
            }
        }
    }
}
