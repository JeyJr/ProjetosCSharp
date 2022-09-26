using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG_Console.PersonagemBase.Habilidades
{
    public class Socar
    {

        public float SocarAdversario(string nomeAtacante, string nomeOponente, float poderDeAtaque)
        {
            float totalDano = poderDeAtaque * 1.2f;

            Console.WriteLine($"{nomeAtacante} desferiu um soco em {nomeOponente}");
            Console.WriteLine($"{nomeOponente} recebeu {totalDano}");
            return totalDano;
        }


    }
}
