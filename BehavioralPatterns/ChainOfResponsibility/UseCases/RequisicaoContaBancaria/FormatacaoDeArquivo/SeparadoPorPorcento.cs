﻿using System.Text;
using ChainOfResponsibility.UseCases.RequisicaoContaBancaria;
using ChainOfResponsibility.UseCases.RequisicaoContaBancaria.Enums;
using ChainOfResponsibility.UseCases.RequisicaoContaBancaria.Interfaces;

namespace ChainOfResponsibility.UseCases.RequisicaoContaBancaria.FormatacaoDeArquivo;

public class SeparadoPorPorcento : ISerializar
{
    public ISerializar Proximo { get; set; }
    public ISerializar? Serializar(Conta conta, Requisicao requisicao)
    {
        if (requisicao.Formato == E_Formato.PORCENTO)
        {
            StringBuilder arquivoPorPorcento = new StringBuilder();
            arquivoPorPorcento.AppendLine("Nome Titular%Saldo");
            arquivoPorPorcento.AppendLine($"{conta.Nome}%{conta.Saldo}");

            File.WriteAllText("Conta.txt", arquivoPorPorcento.ToString());

            return null;
        }

        return Proximo.Serializar(conta, requisicao);
    }
}