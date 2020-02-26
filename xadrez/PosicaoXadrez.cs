using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace jogo_xadrez.xadrez
{
    class PosicaoXadrez
    {
        private int v1;
        private int v2;

        public char coluna { get; set; }
        public int linha { get; set; }
        public PosicaoXadrez(char coluna,int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(coluna - 'a', 8 - linha);
        }
        public override string ToString()
        {
            return ""+coluna+linha;
        }
    }
}
