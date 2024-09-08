using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteOficial
{
    public class Jogadas
    {

        public List<EnumJogadas> Pedra = new List<EnumJogadas> { EnumJogadas.Papel, EnumJogadas.Spook };

        public List<EnumJogadas> Papel = new List<EnumJogadas> { EnumJogadas.Tesoura, EnumJogadas.Lizard };

        public List<EnumJogadas> Spook = new List<EnumJogadas> { EnumJogadas.Papel };

        public List<EnumJogadas> Lizard = new List<EnumJogadas> { EnumJogadas.Pedra, EnumJogadas.Tesoura };

        public List<EnumJogadas> Tesoura = new List<EnumJogadas> { EnumJogadas.Spook, EnumJogadas.Pedra };

        
    }
}
