using JogoRPG_Console.PersonagemBase;
using JogoRPG_Console.PersonagemBase.Habilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG_Console.Jogadores
{
    public class Guerreiro : Profissao
    {
        public override List<Type> MinhasHabilidades { get; set; }


        public Guerreiro() : base("Guerreiro")
        {
            
        }


    }
}
