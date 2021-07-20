using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 井字遊戲
{
    class Program
    {
        // the player field
        static char[,] playField =
        {
            {'1','2','3' },  // row 0
            {'4','5','6' },  // row 1
            {'7','8','9' }   // row 2
        };

        static int turn = 0;

        static void Main(string[] args)
        {

            int player = 2; // Player 1 starts
            int input = 0;
            bool inputCurrent = true;
            

            do
            {
                
                if (player == 2  )
                {
                    
                    player = 1;
                    EnterOorX(player, input);

                }
                else if (player == 1 )
                {
                    player = 2;
                    EnterOorX(player, input);
                }

                SetFeild();

                #region check Winning Condition
                char[] playerChars = { 'O', 'X' };

                foreach (char playerChar in playerChars)
                {
                    if (
                        (playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar)
                        || (playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar)
                        || (playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar)
                        || (playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar)
                        || (playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar)
                        || (playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar)
                        || (playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar)
                        || (playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar)
                        )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\n Player 2 has won!");
                        }
                        else
                        {
                            Console.WriteLine("\n Player 1 has won!");
                        }

                        Console.WriteLine("Press any key to Reset the game ");
                        Console.ReadKey();

                        ResetField();
                        break;

                    }

                    else if (turn == 10)
                    {
                        Console.WriteLine("\n Draw");
                        Console.WriteLine("Press any key to Reset the game ");
                         Console.ReadLine();
                        
                        ResetField();
                        break;
                    }
                }
                #endregion


                #region  check if field is already taken
                do
                {
                    Console.WriteLine("\n Player {0} : Choose your field! ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    if ((input == 1) && (playField[0, 0] == '1'))
                    {
                        inputCurrent = true;
                    }
                    else if ((input == 2) && (playField[0, 1] == '2'))
                    {
                        inputCurrent = true;
                    }
                    else if ((input == 3) && (playField[0, 2] == '3'))
                    {
                        inputCurrent = true;
                    }
                    else if ((input == 4) && (playField[1, 0] == '4'))
                    {
                        inputCurrent = true;
                    }
                    else if ((input == 5) && (playField[1, 1] == '5'))
                    {
                        inputCurrent = true;
                    }
                    else if ((input == 6) && (playField[1, 2] == '6'))
                    {
                        inputCurrent = true;
                    }
                    else if ((input == 7) && (playField[2, 0] == '7'))
                    {
                        inputCurrent = true;
                    }
                    else if ((input == 8) && (playField[2, 1] == '8'))
                    {
                        inputCurrent = true;
                    }
                    else if ((input == 9) && (playField[2, 2] == '9'))
                    {
                        inputCurrent = true;
                    }
                    else
                    {
                        Console.WriteLine("\n Incorrect input! Please choose another field");
                        inputCurrent = false;
                    }
                } while (!inputCurrent);
                #endregion

                


            } while (true);

        }

           


        public static void SetFeild()
        {
            Console.Clear();
            Console.WriteLine("     |     |      ");
            //TODO replace numbers with variebles
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //TODO replace numbers with variebles
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            //TODO replace numbers with variebles
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |     |     ");
            turn++;


        }


        public static void ResetField()
        {
            char[,] playerFieldInitial =
            {
                {'1','2','3' },
                {'4' ,'5','6' },
                {'7','8','9' }
            };

            playField = playerFieldInitial;
            turn = 0;
            SetFeild();

        }


        public static void EnterOorX(int player, int input)
        {
            char playerSign = ' ';
            if (player == 1)
            {
                playerSign = 'X';
            }
            else if (player == 2)
            {
                playerSign = 'O';
            }

            switch (input)
            {
                case 1:
                    playField[0, 0] = playerSign;
                    break;
                case 2:
                    playField[0, 1] = playerSign;
                    break;
                case 3:
                    playField[0, 2] = playerSign;
                    break;
                case 4:
                    playField[1, 0] = playerSign;
                    break;
                case 5:
                    playField[1, 1] = playerSign;
                    break;
                case 6:
                    playField[1, 2] = playerSign;
                    break;
                case 7:
                    playField[2, 0] = playerSign;
                    break;
                case 8:
                    playField[2, 1] = playerSign;
                    break;
                case 9:
                    playField[2, 2] = playerSign;
                    break;
                default:
                    break;
            }

        }
    }
}
