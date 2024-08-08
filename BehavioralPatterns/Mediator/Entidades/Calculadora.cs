namespace Mediator.Entidades;

public class Calculadora
{
    public void CriarCalculadora()
    {
        var textBox1 = new TextBox(null);
        var textBox2 = new TextBox(null);
        var botaoSoma = new Botao(null, "Botão de Soma");
        var botaoSubtracao = new Botao(null, "Botão de Subtração");
        var botaoMultiplicacao = new Botao(null, "Botão de Multiplicação");
        var botaoDivisao = new Botao(null, "Botão de Divisão");

        new ImplementacaoMediador(textBox1, textBox2, botaoSoma, botaoSubtracao, botaoMultiplicacao, botaoDivisao);

        botaoSoma.Click();

        textBox1.Valor = "10";
        textBox2.Valor = "20";

        botaoSubtracao.Click();

        textBox1.Valor = "30";
        textBox2.Valor = "15";
    }
}
