
using PassGenerator;
using System;

namespace PasswordGenerator
{
    class Program
    {


        static void Main(string[] args)
        {
            const int NB_PASSWORD = 10;

            int lengthPassword = outils.AskPositifNumber("Longueur du mot de passe : ");


            Console.WriteLine();
            int choiceAlphabet = outils.AskNumberBetween("You want a password with :\n" +
                "1 - Only lower case letters \n" +
                "2 - Lower and upper case letters \n" +
                "3 - Letters and numbers \n" +
                "4 - Letters, numbers and special characters \n" +
                "Your choice : ", 1, 4);

            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string numbers = "0123456789";
            string specialCharacters = "#&+-!$?_";
            string alphabet;
            string password = "";
            Random rand = new Random();

            if (choiceAlphabet == 1)
                alphabet = minuscules;
            else if (choiceAlphabet == 2)
                alphabet = minuscules + majuscules;
            else if (choiceAlphabet == 3)
                alphabet = minuscules + majuscules + numbers;
            else
                alphabet = minuscules + majuscules + numbers + specialCharacters;

            int longeurAlphabet = alphabet.Length;

            for (int j = 0; j < NB_PASSWORD; j++)
            {
                password = "";
                for (int i = 0; i < lengthPassword; i++)
                {
                    int index = rand.Next(0, longeurAlphabet);
                    password += alphabet[index];
                }

                Console.WriteLine("Password : " + password);
            }
        }
    }
}
