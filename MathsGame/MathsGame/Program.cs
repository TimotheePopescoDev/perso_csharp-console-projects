using System;

namespace MathsGame
{
    class Program
    {
        enum e_Operator
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            SUBTRACTION = 3
        }

        static bool AskQuestion(int min, int max)
        {
            Random rand = new Random();
            int answerInt = 0;

            while (true)
            {
                int a = rand.Next(min, max + 1);
                int b = rand.Next(min, max + 1);
                e_Operator o = (e_Operator)rand.Next(1, 4);
                int expectedResult;


                switch (o)
                {
                    case e_Operator.ADDITION:
                        Console.Write(a + " + " + b + " = ");
                        expectedResult = a + b;
                        break;
                    case e_Operator.MULTIPLICATION:
                        Console.Write(a + " x " + b + " = ");
                        expectedResult = a * b;
                        break;
                    case e_Operator.SUBTRACTION:
                        Console.Write(a + " - " + b + " = ");
                        expectedResult = a - b;
                        break;
                    default:
                    
                        Console.WriteLine("ERROR : Unknown operator");
                        return false;
                }

                string answer = Console.ReadLine();
                try
                {
                    answerInt = int.Parse(answer);
                    if (answerInt == expectedResult)
                    {
                        return true;
                    }

                    return false;
                }
                catch
                {
                    Console.WriteLine("ERROR : You must enter a number");
                }
            }
        }

        static void Main(string[] args)
        {

            const int MIN = -50;
            const int MAX = 50;
            const int NB_QUESTIONS = 5;

            int points = 0;

            for (int i = 0; i < NB_QUESTIONS; i++)
            {
                Console.WriteLine("Question n°" + (i + 1) + "/" + NB_QUESTIONS);
                bool goodAnswer = AskQuestion(MIN, MAX);
                if (goodAnswer)
                {
                    Console.WriteLine("Good answer");
                    points++;
                }
                else
                {
                    Console.WriteLine("Incorrect answer !");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Your result : " + points + "/" + NB_QUESTIONS);

            int moyenne = NB_QUESTIONS / 2;

            if (points == NB_QUESTIONS)
            {
                Console.WriteLine("Excellent !");
            }
            else if (points == 0)
            {
                Console.WriteLine("You need to review !");
            }
            else if (points > moyenne)
            {
                Console.WriteLine("Not bad at all");
            }
            else
            {
                Console.WriteLine("Can do better");
            }
        }
    }
}
