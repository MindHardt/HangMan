using System;
using System.Collections.Generic;

public static class Consos
{
	public static void Write(string word, List<char> pressedletters, int errors)
    {
        Console.Clear();
        char[] letters = word.ToUpper().ToCharArray();
        for (int i = 0; i < letters.Length; i++)
        {
            if (pressedletters.Contains(letters[i])) Console.Write($"{letters[i]} "); else Console.Write("* ");
        }
        Console.WriteLine();
        Console.WriteLine($"Попыток: {errors}");
        Console.Write($"Использованные: ");
        foreach (char c in pressedletters) Console.Write($"{c}, ");
        Console.WriteLine(".");
        Console.WriteLine( "Введите букву: ");
    }
    public static char GetPlayersLetter(List<char> pressedLetters)
    {
        bool error;
        char output = ' ';
        do
        {
            error = false;
            string input = Console.ReadLine().ToUpper();
            if (input.Length != 1) error = true;
            else
            {
                output = (char)input[0];
                if (!('А' <= output && output <= 'Я')) error = true;
                if (pressedLetters.Contains(output)) error = true;
            }
        }
        while (error);
        return (output);
    } 
}
