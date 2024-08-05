﻿using Interpreter.Interfaces;

namespace Interpreter.Entidades;

public class Multiplicacao : IExpressao
{
    public IExpressao Esquerda { get; set; }
    public IExpressao Direita { get; set; }
    public Multiplicacao(IExpressao expressaoEsquerda, IExpressao expressaoDireita)
    {
        Esquerda = expressaoEsquerda;
        Direita = expressaoDireita;
    }

    public int Avalia()
    {
        var valorEsquerda = Esquerda.Avalia();
        var valorDireita = Direita.Avalia();

        return valorEsquerda * valorDireita;
    }
}
