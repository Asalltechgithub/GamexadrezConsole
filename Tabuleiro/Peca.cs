using System;
using System.Collections.Generic;
using System.Text;

namespace AppXadrezConsole.Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimnentos { get; protected set; }

        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.qteMovimnentos = 0;

        }
    }
}
