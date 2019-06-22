﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    enum Choices
    {Rock=1,
    Paper= 2,
    Scissors =3}
    class Program
    {
        static void Main(string[] args)


        {
            const string Rock = "ROCK";
            const string Paper = "PAPER";
            const string Scissors = "SCISSORS";
            const int MaxScore = 3;

            string inputPlayer, inputCPU;
            Choices randomInt;
        
           
            bool playAgain = true;


            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {


                    Console.Write("choose between {0}, {1}, and {2}:       ",Rock,Paper,Scissors);
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();
                    randomInt = (Choices)rnd.Next(1, 4);
                    inputCPU = randomInt == Choices.Rock ? Rock : randomInt == Choices.Paper ? Paper : Scissors;
                    Console.WriteLine("computer chose " + inputCPU);

                    switch (randomInt)
                    {
                        case Choices.Rock:

                            if (inputPlayer == inputCPU)
                                Console.WriteLine("draw");

                            else if (inputPlayer == Paper)
                            {
                                Console.WriteLine("PLAYER WINS");
                                scorePlayer++;
                            }


                            else if (inputPlayer == Scissors)
                            {
                                Console.WriteLine("CPU WINS");
                                scoreCPU++;
                            }
                            break;
                        case Choices.Paper:

                            if (inputPlayer == inputCPU)
                                Console.WriteLine("draw");

                            else if (inputPlayer == Scissors)
                            {
                                Console.WriteLine("PLAYER WINS");
                                scorePlayer++;
                            }

                            else if (inputPlayer == Rock)
                            {
                                Console.WriteLine("CPU WINS");
                                scoreCPU++;
                            }
                            break;

                        case Choices.Scissors:

                            if (inputPlayer == inputCPU)

                                Console.WriteLine("draw");

                            else if (inputPlayer == Rock)


                            {
                                Console.WriteLine("PLAYER WINS");
                                scorePlayer++;
                            }


                            else if (inputPlayer == Paper)
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

                    if (scorePlayer == MaxScore)
                    {
                        Console.WriteLine("player wins");
                    }

                    else if (scoreCPU == MaxScore)
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
