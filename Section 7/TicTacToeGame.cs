using System;

namespace TicTacToeGame
{
    class Program
    {
        public static string player = "1"; //player 1 starts
        public static string[] positions = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public static int numberOfTurns = 1;
        public static string symbol = "";
        public static bool keepPlaying = true;
        public static bool isThereAWinner = false;
        static void Main(string[] args)
        {
            PlayGame();
        }

        public static void PlayGame()
        {
            Console.Clear();
            DisplayBoard();
            MakeChoice();
            //Console.ReadKey();
        }

        public static void MakeChoice()
        {
            
            //only alow 9 guesses as no more are possible and if someone has already won do not keepPlaying
            while (numberOfTurns < 10 && keepPlaying)
            {
                //check the player to see which symbol to use on the board
                if (player == "1")
                {
                    symbol = "X";
                } else
                {
                    symbol = "O";
                }
                //ask player to input chosen position
                Console.WriteLine("\nPlayer {0} - Please enter your chosen position: ", player);
                string positionEntered = Console.ReadLine();
                //check input is a valid position on the board if it already taken or invalid input ask for input again
                bool validInput = Array.Exists(positions, element => element == positionEntered);

                if (validInput)
                {
                    //check the location of the entered position in the array of positions
                    int locationInArray = Array.IndexOf(positions, positionEntered);

                    //put the players symbol in the chosen position
                    positions[locationInArray] = symbol;

                    //check to see if someone has won after entering the position in the board
                    CheckForAWinner();
                    Console.Clear();
                    numberOfTurns++;

                    //only switch players if there is not a winner yet, if someone has won that player will be printed in displayWinner
                    if (!isThereAWinner)
                    {
                        SwitchPlayer();
                    }
                    DisplayBoard();
                } else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid position!");
                    Console.ForegroundColor = ConsoleColor.White;
                    DisplayBoard();
                }
                
            }

            DisplayWinner();
        }

        public static void DisplayWinner()
        {
            if (isThereAWinner)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nThe winner is player {0}!", player);
                Console.ForegroundColor = ConsoleColor.White;
                PlayAgain();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nThe game was a draw!");
                Console.ForegroundColor = ConsoleColor.White;
                PlayAgain();
            }
        }

        public static void PlayAgain()
        {
            //ask user if they want to play again
            Console.WriteLine("Do you want to play again?\n" +
                "Type Y and press Enter to play again\n" +
                "Otherwise just press Enter to exit");
            string playAgainValue = Console.ReadLine();
            //if they type yes reset all values to start a new game
            if ( playAgainValue.ToUpper() == "Y")
            {
                numberOfTurns = 1;
                positions[0] = "1";
                positions[1] = "2";
                positions[2] = "3";
                positions[3] = "4";
                positions[4] = "5";
                positions[5] = "6";
                positions[6] = "7";
                positions[7] = "8";
                positions[8] = "9";
                keepPlaying = true;
                isThereAWinner = false;
                player = "1";
                PlayGame();
            //otherwise close the console
            } else
            {
                Environment.Exit(0);
            }
        }
        public static void CheckForAWinner()
        {
            if (((positions[0] == "X") && (positions[1] == "X") && (positions[2] == "X")) || ((positions[3] == "X") && (positions[4] == "X") && (positions[5] == "X")) || ((positions[6] == "X") && (positions[7] == "X") && (positions[8] == "X")) || ((positions[0] == "X") && (positions[3] == "X") && (positions[6] == "X")) || ((positions[1] == "X") && (positions[4] == "X") && (positions[7] == "X")) || ((positions[2] == "X") && (positions[5] == "X") && (positions[8] == "X")) || ((positions[0] == "X") && (positions[4] == "X") && (positions[8] == "X")) || ((positions[2] == "X") && (positions[4] == "X") && (positions[6] == "X")))
            {
                //set keepPlaying to false if there is a winning row
                keepPlaying = false;
                //set isThereAWinner to true to print out winning message
                isThereAWinner = true;
            } else if (((positions[0] == "O") && (positions[1] == "O") && (positions[2] == "O")) || ((positions[3] == "O") && (positions[4] == "O") && (positions[5] == "O")) || ((positions[6] == "O") && (positions[7] == "O") && (positions[8] == "O")) || ((positions[0] == "O") && (positions[3] == "O") && (positions[6] == "O")) || ((positions[1] == "O") && (positions[4] == "O") && (positions[7] == "O")) || ((positions[2] == "O") && (positions[5] == "O") && (positions[8] == "O")) || ((positions[0] == "O") && (positions[4] == "O") && (positions[8] == "O")) || ((positions[2] == "O") && (positions[4] == "O") && (positions[6] == "O")))
            {
                keepPlaying = false;
                isThereAWinner = true;
            } else
            {
                isThereAWinner = false;
            }
        }
        public static void SwitchPlayer()
        {
            if (player == "1")
            {
                player = "2";
            } else
            {
                player = "1";
            }
        }
        public static void DisplayBoard()
        {
            Console.WriteLine(""); 
            Console.WriteLine("     |     |     "); 
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", positions[0], positions[1], positions[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     "); 
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", positions[3], positions[4], positions[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     "); 
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", positions[6], positions[7], positions[8]);
            Console.WriteLine("     |     |     ");
        }
    }
}
