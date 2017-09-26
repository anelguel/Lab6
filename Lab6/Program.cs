using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            { 
                Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine("Enter a word to be translated:");
            string word = Console.ReadLine();//reads back user input
            word = word.ToLower();//brings input word to lowercase
            List<char> vowels = new List<char>() { 'a', 'o', 'e', 'u', 'i' };//declares a list of vowels
            char letters = word.ToCharArray()[0];//creates an array list of the word that was inputted, pulls the FIRST word of array

                if (vowels.Contains(letters))//if the first letter is a vowel
                {
                    word += "way";
                    Console.WriteLine(word);
                }
                else  //else if the first letter not a vowel
                {
                    string consonant = "";
                    string finalWord = "";
                    char[] letters2 = word.ToCharArray();
                    foreach (char l in letters2)
                    {
                        if (!vowels.Contains(l))
                        {
                            consonant += l;
                        }
                        else
                        {
                            int vowellocation = word.IndexOf(l); // index returns number of vowel location
                            int length = word.Length - vowellocation;
                            finalWord = word.Substring(vowellocation, length);
                            finalWord += consonant;
                            finalWord += "ay";
                            break;

                        }
                    }
                    Console.WriteLine(finalWord);
                }
                run = Continue();
            }
            
        }
        

        public static bool Continue()
        {
            Console.WriteLine("Do you wish to Continue? y/n");
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

        
