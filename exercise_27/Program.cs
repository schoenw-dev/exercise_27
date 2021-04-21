using System;

namespace Practice_3
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("please enter your submission:");
            string userInput = Console.ReadLine().ToLower();
            Console.WriteLine(VowelCount(userInput));

        }

        public static int VowelCount(string input)
        {
            int total = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] != vowels[0]) || (input[i] != vowels[1]) || (input[i] != vowels[2]) ||
                    (input[i] != vowels[3]) || (input[i] != vowels[4]))

                {
                    total = total + 1;
                }
            }
            return total;

        }
    }
}
