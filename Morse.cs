using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encode_Morse
{
   public class Morse
    {
        public string Translate(string word)
        {
            char[] chars = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string[] morse = { " ", ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "--.--", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--..", "---..", "----." };

            string wordmorse = "";
            word = word.ToLower();

            for(int i=0; i < word.Length; i++)
            {
                for(int j=0; j < 38; j++)
                {
                    if(word[i]== chars[j])
                    {
                        wordmorse += morse[j];
                        wordmorse += " ";
                        break;
                    }
                }
            }

            Console.WriteLine("La palabra en codigo morse es: ");
            return wordmorse;
        }


    }
}
