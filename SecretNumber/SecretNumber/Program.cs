using System;
using System.Net.Sockets;

namespace SecretNumber
{
    class Program
    {
        // AskNumber
        // display : Enter a number
        // test if this number is valid (conversion -> try/catch) -> ERROR : this number is not valid
        // loop as long as the number is not valid
        // consider that 0 is invalid
        // return the value (int)

        static int AskNumber(int min, int max)
        {
            int userNumber = max + 1;

            while ((userNumber < min) || (userNumber > max))
            {
                Console.Write("Enter a number between " + min + " and " + max + " : ");
                string answer = Console.ReadLine();

                try
                {
                    userNumber = int.Parse(answer);

                    if ((userNumber < min) || (userNumber > max))
                    {
                        Console.WriteLine("ERROR : The number must be between " + min + " and " + max);
                    }

                }
                catch
                {
                    Console.WriteLine("ERROR : Enter a valid number");
                }
            }

            return userNumber;
        }

        static void Main(string[] args)
        {
            Random randint = new Random();

            const int MIN = 1;
            const int MAX = 10;
            int secretNumber = randint.Next(MIN, MAX + 1);


            int number = secretNumber + 1;

            int lifes = 3;

            while (lifes > 0) 
            {
                Console.WriteLine();
                Console.WriteLine("Vies restantes : " + lifes);
                number = AskNumber(MIN,MAX);

                if (secretNumber > number)
                {
                    Console.WriteLine("Secret number is bigger");
                }
                else if (secretNumber < number)
                {
                    Console.WriteLine("Secret number is smaller");
                }
                else
                {
                    Console.WriteLine("Congrats, you find the secret number");
                    break;
                }
                lifes--;
            }

            if (lifes == 0)
            {
                Console.WriteLine("You loose, the secret number was : " + secretNumber);
            }

        }
    }
}
