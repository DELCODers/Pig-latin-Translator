using System;

namespace pig_latin_translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator");
            Console.WriteLine();

            Console.Write("Enter a line to be translated:");
            string word = Console.ReadLine();

            int VowelPosition = -1;
            foreach (char letter in word)
            {
                 VowelPosition = VowelPosition + 1;
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    break;
                } 
            }
            string PigLatinWord = "";
            string BeforeLetters = "";
            string AfterLetters = "";
            switch (VowelPosition)



            {


                case 0:
                    PigLatinWord = word + "way";
                    break;
                case 1:
                    BeforeLetters = word.Substring(0, 1);
                    AfterLetters = word.Substring(1);
                    PigLatinWord = AfterLetters + BeforeLetters + "ay";
                    break;
                case 2:
                    BeforeLetters = word.Substring(0, 2);
                    AfterLetters = word.Substring(2);
                    PigLatinWord = AfterLetters + BeforeLetters + "ay";
                    break;
             
            }

            Console.WriteLine(""  + PigLatinWord);
            
             
        }
       
    }
}
