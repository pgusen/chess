﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro.Enums;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            Posicao = posicao;
            Tab = tab;
            Cor = cor;
            QteMovimentos = 0;
        }
    }
}