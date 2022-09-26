using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG_Console.PersonagemBase
{
    public abstract class Atributos 
    {
        private int vida;
        private float atk;

        public int Vida { get => vida; set => vida = value; }
        public float Atk { get => atk; set => atk = value; }

        public Atributos(int _vida, int _atk)
        {
            Vida = _vida;
            Atk = _atk;
        }


    }
}
