using System;

namespace Encode_Morse
{
    class Program
    {
        static void Main(string[] args)
        {
            Morse morse = new Morse();
            Console.WriteLine("Ingrese la palabra a ser llevada a codigo morse: ");
            string word = Console.ReadLine();
            Console.WriteLine(morse.Translate(word));
            Console.ReadKey();
        }
    }
}
