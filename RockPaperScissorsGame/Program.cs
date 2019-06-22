using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
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
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {


                    Console.Write("choose between ROCK, PAPER, and SCISSORS:       ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);


                    switch (randomInt)
                    {
                        case 1:

                            inputCPU = "ROCK";
                            Console.WriteLine("computer chose ROCK");
                            if (inputPlayer == "ROCK")
                                Console.WriteLine("draw");

                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS");
                                scorePlayer++;
                            }


                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS");
                                scoreCPU++;
                            }
                            break;
                        case 2:

                            inputCPU = "PAPER";
                            Console.WriteLine("computer chose PAPER");
                            if (inputPlayer == "PAPER")
                                Console.WriteLine("draw");

                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS");
                                scoreCPU++;
                            }
                            break;

                        case 3:

                            inputCPU = "SCISSORS";
                            Console.WriteLine("computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")

                                Console.WriteLine("draw");

                            else if (inputPlayer == "ROCK")


                            {
                                Console.WriteLine("PLAYER WINS");
                                scorePlayer++;
                            }


                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS");
                                scoreCPU++;
                            }

                            break;

                        default:
                            Console.WriteLine("invalid entry");
                            break;



                    }
                    Console.WriteLine("Scores :\tplayer  {0}  \t CPU  {1}",scorePlayer,scoreCPU);

                    if (scorePlayer == 3)
                    {
                        Console.WriteLine("player wins");
                    }

                    else if (scoreCPU == 3)
                    {
                        Console.WriteLine("CPU wins");
                    }

                    else
                    {

                    }
                }

                string Restart = "";
                do
                {
                    Console.WriteLine("would you like to play again Y/N");
                 Restart = Console.ReadLine().ToUpper();
                
                    if (Restart == "Y")
                    {
                        playAgain = true;
                    }

                    else if (Restart == "N")
                    {

                        playAgain = false;
                    }
                } while (Restart != "N" && Restart != "Y");
                


            }
        }
    }
}
