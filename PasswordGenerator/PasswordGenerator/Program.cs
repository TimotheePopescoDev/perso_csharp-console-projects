
using PassGenerator;
using System;

namespace PasswordGenerator
{
    class Program
    {


        static void Main(string[] args)
        {
            const int NB_PASSWORD = 10;

            int lengthPassword = outils.AskPositifNumber("Length of the password : ");


            Console.WriteLine();
            int choiceAlphabet = outils.AskNumberBetween("You want a password with :\n" +
                "1 - Only lower case letters \n" +
                "2 - Lower and upper case letters \n" +
                "3 - Letters and numbers \n" +
                "4 - Letters, numbers and special characters \n" +
                "Your choice : ", 1, 4);

            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = lowercase.ToUpper();
            string numbers = "0123456789";
            string specialCharacters = "#&+-!$?_";
            string alphabet;
            string password = "";
            Random rand = new Random();

            if (choiceAlphabet == 1)
                alphabet = lowercase;
            else if (choiceAlphabet == 2)
                alphabet = lowercase + uppercase;
            else if (choiceAlphabet == 3)
                alphabet = lowercase + uppercase + numbers;
            else
                alphabet = lowercase + uppercase + numbers + specialCharacters;

            int lengthAlphabet = alphabet.Length;

            for (int j = 0; j < NB_PASSWORD; j++)
            {
                password = "";
                for (int i = 0; i < lengthPassword; i++)
                {
                    int index = rand.Next(0, lengthAlphabet);
                    password += alphabet[index];
                }

                Console.WriteLine("Password : " + password);
            }
        }
    }
}
