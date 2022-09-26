using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JogoRPG_Console.PersonagemBase.Habilidades;

namespace JogoRPG_Console.PersonagemBase
{
    public abstract class Profissao : Atributos
    {
        public string MinhaProfissao { get; private set; }
        public abstract List<Type> MinhasHabilidades { get; set; }    


        public Profissao(string profissao) : base(20, 10)
        {
            MinhaProfissao = profissao;
        }

        


    }
}
