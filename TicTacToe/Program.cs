namespace TicTacToe
{
    internal class Program
    {
        static string[,] gameBoard = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

        static List<string> listWithNumbers = new List<string>();

        const string playerO = "O";
        const string playerX = "X";



        static void Main(string[] args)
        {
            bool isGameRunning = true;

            PrintGameBoard();

            while (isGameRunning)
            {
                
                Console.WriteLine("\n\nPlayer O, chose a number on the board: ");
                string choiceO = Console.ReadLine();
                
                if (IsNewNumber(choiceO))
                {
                    listWithNumbers.Add(choiceO);
                    (int a, int b) = ChooseNumber(choiceO);
                    Console.Clear();
                    NewGameBoard(a, b, playerO);

                    if (IsWinning(playerO))
                    {
                        Console.WriteLine("\nYou won player " + playerO + "!");
                        isGameRunning = false;
                       
                    }
                    
                }
                else
                {
                    Console.WriteLine("\nThis number was already taken...");
                }
                
                Console.WriteLine("\n\nPlayer X, chose a number on the board: ");
                string choiceX = Console.ReadLine();
                
                if (IsNewNumber(choiceX))
                {
                    listWithNumbers.Add(choiceX);
                    (int c, int d) = ChooseNumber(choiceX);
                    Console.Clear();
                    NewGameBoard(c, d, playerX);

                    if (IsWinning(playerX))
                    {
                        Console.WriteLine("You won player " + playerX + "!");
                        
                        isGameRunning = false;
                       
                    }
                }
                else
                {
                    Console.WriteLine("\nThis number was already taken...");
                }

                
            }
            Console.ReadKey();


        }
        static void PrintGameBoard()
        {
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    
                    Console.Write(gameBoard[i, j] + " ");

                }
                Console.WriteLine();
            }
        }

        static string[,] NewGameBoard(int a, int b, string gamer)
        {
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    if (i == a && j == b && gamer == "O")
                    {
                        gameBoard[i, j] = "O";
                        Console.Write(gameBoard[i,j] + " ");
                    }
                    else if (i == a && j == b && gamer == "X")
                    {
                        gameBoard[i, j] = "X";
                        Console.Write(gameBoard[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(gameBoard[i, j] + " ");
                    }

                }
                Console.WriteLine();
            }
            return gameBoard;
            
        }

        static bool IsNewNumber(string input)
        {
            foreach (var item in listWithNumbers)
            {
                if (input == item)
                {
                    return false;
                }
                
            }
            return true;
        }

        static bool IsWinning(string player)
        {
            if (gameBoard[0, 0] == player && gameBoard[0, 1] == player && gameBoard[0, 2] == player ||
                gameBoard[1, 0] == player && gameBoard[1, 1] == player && gameBoard[1, 2] == player ||
                gameBoard[2, 0] == player && gameBoard[2, 1] == player && gameBoard[2, 2] == player ||
                gameBoard[0, 0] == player && gameBoard[1, 0] == player && gameBoard[2, 0] == player ||
                gameBoard[1, 0] == player && gameBoard[1, 1] == player && gameBoard[2, 1] == player ||
                gameBoard[2, 0] == player && gameBoard[2, 1] == player && gameBoard[2, 2] == player ||
                gameBoard[0, 0] == player && gameBoard[1, 1] == player && gameBoard[2, 2] == player ||
                gameBoard[0, 2] == player && gameBoard[1, 1] == player && gameBoard[2, 0] == player)
                
            {
                return true;
            }
            else
            {
                return false;
            }

           
        }
       

        static (int, int) ChooseNumber(string stringNumber)
        {
            int a = 0;
            int b = 0;
            switch (stringNumber)
            {
                case "1":
                    a = 0;
                    b = 0;
                    break;
                    
                case "2":
                    a = 0;
                    b = 1;
                    break;

                case "3":
                    a = 0;
                    b = 2;
                    break;

                case "4":
                    a = 1;
                    b = 0;
                    break;

                case "5":
                    a = 1;
                    b = 1;
                    break;

                case "6":
                    a = 1;
                    b = 2;
                    break;

                case "7":
                    a = 2;
                    b = 0;
                    break;

                case "8":
                    a = 2;
                    b = 1;
                    break;

                case "9":
                    a = 2;
                    b = 2;
                    break;

              
            }
            return (a, b);
        }

       
    }
}