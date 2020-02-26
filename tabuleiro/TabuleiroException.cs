using System;
using System.Collections.Generic;
using System.Text;

namespace jogo_xadrez.tabuleiro
{
    class TabuleiroException:Exception
    {
        public TabuleiroException(string msg):base(msg)
        {

        }
    }
}
