using System;
using System.Collections.Generic;
using System.Text;


namespace PassGenerator
{
    static class outils
    {
        public static int AskPositifNumber(string question)
        {
            return AskNumberBetween(question, 1, int.MaxValue, "ERROR: The number must be positive and not zero");
        }

        public static int AskNumberBetween(string question, int min, int max, string messageErrorCustomized = null)
        {
            int number = AskNumber(question);
            if ((number >= min) && (number <= max))
            {
                return number;
            }
            if (messageErrorCustomized == null)
            {
                Console.WriteLine("ERROR : The number must be between " + min + " and " + max);
            }
            else
            {
                Console.WriteLine(messageErrorCustomized);
            }

            Console.WriteLine();

            return AskNumberBetween(question, min, max, messageErrorCustomized);
        }

        public static int AskNumber(string question)
        {
      
            while (true)
            {
                Console.Write(question);
                string answer = Console.ReadLine();
                try
                {
                    int answerInt = int.Parse(answer);
                    return answerInt;
                }
                catch
                {
                    Console.WriteLine("ERROR : You must enter a number");
                    Console.WriteLine();
                }
            }
        }

    }
}
