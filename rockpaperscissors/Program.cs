using System;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

            while (scorePlayer < 3 && scoreCPU <3)
            {



            Console.Write("Choose between ROCK, PAPER and SCISSORS:     ");
            inputPlayer = Console.ReadLine();


            Random rnd = new Random();

            randomInt = rnd.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose ROCK");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("DRAW!!\n\n");

                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("Player WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.Write("CPU Wins!!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer chose PAPER");
                    if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("DRAW!!\n\n");

                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("Player WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.Write("CPU Wins!!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer chose SCISSORS");
                    if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("DRAW!!\n\n");

                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("Player WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.Write("CPU Wins!!\n\n");
                        scoreCPU++;
                    }
                    break;
                default:
                    break;
                }
            }

        }
    }
}
