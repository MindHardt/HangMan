using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> pressedLetters = new List<char>();
            while (true && Game.GameGoes)
            {
                Consos.Write(Game.Word, pressedLetters, Game.Errors);
                char playersLetter = Consos.GetPlayersLetter(pressedLetters);
                if (Game.Word.Replace(playersLetter, '0') == Game.Word) Game.Errors--;
                pressedLetters.Add(playersLetter);
                Game.CheckGame(pressedLetters);
            }
        }
    }
}
