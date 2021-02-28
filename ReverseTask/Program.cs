using System;

namespace ReverseTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "the sky is blue";
            Console.WriteLine(sentence);
            
            var reversedtext = Utils.Reverse(sentence);

            Console.WriteLine(reversedtext);
            Console.ReadKey();
        }
    }
}
