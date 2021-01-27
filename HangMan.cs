using System;
using System.IO;
using System.Collections.Generic;

namespace Hangman
{
	public static class Game
	{
		private static string word = GetWord();
		public static string Word
        {
			get { return word;  }
			set { word = value; }
        }
		private static bool gameGoes = true;
		public static bool GameGoes
        {
			get { return (gameGoes); }
        }
		private static int errors = 7;
		public static int Errors
		{
			get { return (errors); }
			set { errors = value; }
		}
		public static string GetWord()
		{
			Random rnd = new Random();
			string line = string.Empty;
			int word = rnd.Next(1, File.ReadAllLines(Environment.CurrentDirectory + "\\original.txt").Length);
			string factWord = File.ReadAllLines(Environment.CurrentDirectory + "\\original.txt")[word-1];
			return (factWord.ToUpper());
		}
		public static void CheckGame(List<char> pressedLetters)
        {
			bool solved = true;
			foreach (char c in word) if (!pressedLetters.Contains(c)) solved = false;
			if (solved)
			{
				Console.WriteLine($"Вы победили! {Game.Word}");
				Console.ReadLine();
				Environment.Exit(0);
			}
			else if (errors < 0)
			{
				Console.WriteLine($"Вы проиграли : ( {Game.Word}");
				Console.ReadLine();
				Environment.Exit(0);

			}
        }
	
	}

}
