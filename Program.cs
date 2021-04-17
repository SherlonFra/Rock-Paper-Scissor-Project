using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissor_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int playerScore = 0;
                int cpuScore = 0;

                Console.WriteLine("**************");
                Console.WriteLine("*   WELCOME  * " + "\n*     TO     *" + "\n* ROCK PAPER * " + "\n*   SCISSOR  *");
                Console.WriteLine("**************");

                while (playerScore < 3 && cpuScore< 3)
                {
                    Console.Write("Choose between ROCK, PAPER and SCISSORS:");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

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
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                cpuScore++;
                            }
                            else { Console.WriteLine("Invalid entry!"); }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                cpuScore++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            else { Console.WriteLine("Invalid entry!"); }
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
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                cpuScore++;
                            }
                            else { Console.WriteLine("Invalid entry!"); }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", playerScore, cpuScore);

                }

                if (playerScore == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (cpuScore == 3)
                {
                    Console.WriteLine("CPU WON!");
                }
                else
                {

                }

                Console.WriteLine("Press y to play again/ press n to quit");
                string restart = Console.ReadLine();
                if (restart == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (restart == "n")
                {
                    playAgain = false;
                }
                else
                {

                }

            }
        }
    }
}
