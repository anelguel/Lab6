using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
/*Lab 6
 * Task: Translate text from English to Pig Latin.
 * The application will:
 * 1. Prompt for user input.
 * 2. Translate the test to Pig Latin and display it to the console.
 * 3. Ask the user if he/she wants to continue.
 * Build specifications:
 * 1. Convert each word to lower case before translating.
 * 2. If a word starts with a vowel, add "way" to the end.
 * 3. If a word starts with a consonant, move all the consonants that appear before the first vowel to the end of the word, then add "ay" to the end.
*/
{
	class Program
	{
		static void Main(string[] args)
		{
			bool run = true;
			while (run == true)
			{
				Console.WriteLine("Welcome to the Pig Latin Translator! \nPlease enter a line to be translated:");
				string input = Console.ReadLine().ToLower();

				var words = input.Split(' ');
				var pigWords = new List<string>();

				foreach (string word in words)
				{
					string firstLetter = word.Substring(0, 1);
					string restOfWord = word.Substring(1, word.Length - 1);

					if (firstLetter == "a" || firstLetter == "e" || firstLetter == "i" || firstLetter == "o" || firstLetter == "u")
					{
						pigWords.Add(word + "way");
					}
					else
					{
						pigWords.Add(restOfWord + firstLetter + "ay");
					}
				}

				var pigSentence = string.Join(" ", pigWords);

				Console.WriteLine(pigSentence);
				Console.ReadLine();
				run = Continue();
			}

		}
		public static bool Continue()
		{
			Console.WriteLine("Do you wish to continue? y/n");
			string input = Console.ReadLine();
			input = input.ToLower();
			bool goOn;
			if (input == "y")
			{
				goOn = true;
			}
			else if (input == "n")
			{
				goOn = false;
			}
			else
			{
				Console.WriteLine("I don't understand that, let's try again");
				goOn = Continue();
			}
			return goOn;
		}
	}
}