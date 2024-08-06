﻿using Visitor.Interfaces;

namespace Visitor.Entidades;

public class Subtracao : IExpressao
{
    public IExpressao Esquerda { get; set; }
    public IExpressao Direita { get; set; }
    public Subtracao(IExpressao expressaoEsquerda, IExpressao expressaoDireita)
    {
        Esquerda = expressaoEsquerda;
        Direita = expressaoDireita;
    }

    public int Avalia()
    {
        var valorEsquerda = Esquerda.Avalia();
        var valorDireita = Direita.Avalia();

        return valorEsquerda - valorDireita;
    }

    public void Aceita(IVisitor impressora)
    {
        impressora.ImprimeSubtracao(this);
    }
}