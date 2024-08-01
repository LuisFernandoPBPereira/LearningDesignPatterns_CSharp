﻿using TemplateMethod.Imposto.Interfaces;

namespace TemplateMethod.Imposto.Entidades.Impostos;

public class ISS : IImposto
{
    public double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06;
    }
}
