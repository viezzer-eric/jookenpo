using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteOficial
{
    public class Program
    {
         public readonly IJookenPo _jooken;

        public Program( IJookenPo jooken) =>  _jooken = jooken;

        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddSingleton<IJookenPo, JooKenPo>()
            .BuildServiceProvider();

            KeyValuePair<string, EnumJogadas> p1 = new KeyValuePair<string, EnumJogadas>("Eric", EnumJogadas.Papel);
            KeyValuePair<string, EnumJogadas> p2 = new KeyValuePair<string, EnumJogadas>("Melissa", EnumJogadas.Tesoura);

            Console.WriteLine(serviceProvider.GetService<IJookenPo>().QuemPerde(p1, p2));
            Console.Read();

        }

    }
}
