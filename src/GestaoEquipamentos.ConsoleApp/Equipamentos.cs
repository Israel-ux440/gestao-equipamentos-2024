﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp
{
    public class Equipamento
    {
        public string Nome;
        public string NumeroSerie;
        public string Fabricante;
        public decimal PrecoAquisicao;
        public DateTime DataFabricacao;

        public Equipamento(string nome, string numeroSerie, string fabricante, decimal precoAquisicao, DateTime dataFabricacao)
        {
            Nome = nome;
            NumeroSerie = numeroSerie;
            Fabricante = fabricante;
            PrecoAquisicao = precoAquisicao;
            DataFabricacao = dataFabricacao;
        }
    }
}
