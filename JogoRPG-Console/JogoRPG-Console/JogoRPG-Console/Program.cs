using System;
using JogoRPG_Console.Jogadores;
using JogoRPG_Console.PersonagemBase;
using JogoRPG_Console.Inimigos;

namespace JogoRPG_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var player = new Guerreiro();

            Console.WriteLine( $"Vida: {player.Vida}");
            Console.WriteLine( $"Atk: {player.Atk}");
            Console.WriteLine( $"Profissao: {player.MinhaProfissao}");

            Console.ReadLine();

        }
    }
}
