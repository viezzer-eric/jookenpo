using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteOficial
{
    public class JooKenPo : IJookenPo
    {

        public string QuemPerde(KeyValuePair<string, EnumJogadas> player1, KeyValuePair<string, EnumJogadas> player2)
        {
            try
            {
                EnumJogadas valor1 = player1.Value;
                EnumJogadas valor2 = player2.Value;

                if (valor1 == valor2) { return "Empate"; };

                if (RetornaPerdedor(player1.Value).Contains(player2.Value))
                {
                    return $"VENCEDOR: {player2.Key}";
                }
                else
                {
                    return $"VENCEDOR: {player1.Key}";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<EnumJogadas> RetornaPerdedor(EnumJogadas jogada)
        {
            Jogadas jogadas = new Jogadas();

            if (jogada.Equals(EnumJogadas.Pedra))
            {
                return jogadas.Pedra;
            }

            if (jogada.Equals(EnumJogadas.Papel))
            {
                return jogadas.Papel;
            }

            if (jogada.Equals(EnumJogadas.Tesoura))
            {
                return jogadas.Tesoura;
            }

            if (jogada.Equals(EnumJogadas.Spook))
            {
                return jogadas.Spook;
            }

            if (jogada.Equals(EnumJogadas.Lizard))
            {
                return jogadas.Lizard;
            }

            return Enumerable.Empty<EnumJogadas>();

        }
    }
}
