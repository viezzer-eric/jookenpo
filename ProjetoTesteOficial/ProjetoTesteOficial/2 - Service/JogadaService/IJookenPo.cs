using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteOficial
{
    public interface IJookenPo
    {
        string QuemPerde(KeyValuePair<string, EnumJogadas> player1, KeyValuePair<string, EnumJogadas> player2);
        IEnumerable<EnumJogadas> RetornaPerdedor(EnumJogadas jogada);
    }
}
