using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "1";
            string B = "2";
            string C = "3";
            string D = "4";
            string E = "5";
            string F = "6";
            string G = "7";
            string H = "8";
            string I = "9";
            string player1;
            string player2;
            string turn = "Player1";
            string selection;
            bool win = false;
            bool playAgain = false;


            Console.WriteLine("Enter the name of the first player.");
            player1 = Console.ReadLine();
            Console.WriteLine("Enter the name of the second player.");
            player2 = Console.ReadLine();
            Start:

            Console.Clear();

            //Player 1 Turn
            if (turn == "Player1")
            {
                turn = "Player2";
                Console.Clear();
                Console.WriteLine("Current Player: " + player1);
                Console.WriteLine("");
                //Draw board
                Console.WriteLine(A + "|" + B + "|" + C);
                Console.WriteLine(D + "|" + E + "|" + F);
                Console.WriteLine(G + "|" + H + "|" + I);
                Console.WriteLine("");
                Console.WriteLine("Select a position.");
                selection = Console.ReadLine();

                //Player chooses position
                if (selection == "1")
                {
                    if (A == "1")
                    {
                        A = "X";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "2")
                {
                    if (B == "2")
                    {
                        B = "X";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "3")
                {
                    if (C == "3")
                    {
                        C = "X";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "4")
                {
                    if (D == "4")
                    {
                        D = "X";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "5")
                {
                    if (E == "5")
                    {
                        E = "X";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "6")
                {
                    if (F == "6")
                    {
                        F = "X";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "7")
                {
                    if (G == "7")
                    {
                        G = "X";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "8")
                {
                    if (H == "8")
                    {
                        H = "X";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "9")
                {
                    if (I == "9")
                    {
                        I = "X";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                //Check for Horizontal Win
                if (A == "X" && B == "X" && C == "X")
                {
                    win = true;
                    Console.WriteLine(player1 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
                if (D == "X" && E == "X" && F == "X")
                {
                    win = true;
                    Console.WriteLine(player1 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
                if (G == "X" && H == "X" && I == "X")
                {
                    win = true;
                    Console.WriteLine(player1 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }

                //Check for Vertical Win
                if (A == "X" && D == "X" && G == "X")
                {
                    win = true;
                    Console.WriteLine(player1 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
                if (B == "X" && E == "X" && H == "X")
                {
                    win = true;
                    Console.WriteLine(player1 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
                if (C == "X" && F == "X" && I == "X")
                {
                    win = true;
                    Console.WriteLine(player1 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }

                //Check for Diagonal Win
                if (A == "X" && E == "X" && I == "X")
                {
                    win = true;
                    Console.WriteLine(player1 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
                if (C == "X" && E == "X" && G == "X")
                {
                    win = true;
                    Console.WriteLine(player1 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }

                if (win == true)
                {


                    if (playAgain == true)
                    {
                        win = false;
                        playAgain = false;
                        turn = "Player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;

                    }
                    else if (playAgain == false)
                    {
                        Console.WriteLine("Thanks for playing");
                        Console.Read();
                    }
                }



            }

            //Player 2 Turn
            if (turn == "Player2")
            {
                turn = "Player1";
                Console.Clear();
                Console.WriteLine("Current Player: " + player2);
                Console.WriteLine("");
                //Draw board
                Console.WriteLine(A + "|" + B + "|" + C);
                Console.WriteLine(D + "|" + E + "|" + F);
                Console.WriteLine(G + "|" + H + "|" + I);
                Console.WriteLine("");
                Console.WriteLine("Select a position.");
                selection = Console.ReadLine();

                //Player chooses position
                if (selection == "1")
                {
                    if (A == "1")
                    {
                        A = "O";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "2")
                {
                    if (B == "2")
                    {
                        B = "O";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "3")
                {
                    if (C == "3")
                    {
                        C = "O";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "4")
                {
                    if (D == "4")
                    {
                        D = "O";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "5")
                {
                    if (E == "5")
                    {
                        E = "O";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "6")
                {
                    if (F == "6")
                    {
                        F = "O";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "7")
                {
                    if (G == "7")
                    {
                        G = "O";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "8")
                {
                    if (H == "8")
                    {
                        H = "O";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                if (selection == "9")
                {
                    if (I == "9")
                    {
                        I = "O";
                    }
                    else
                    {
                        Console.WriteLine("That space is already taken.");
                    }
                }

                //Check for Horizontal Win
                if (A == "O" && B == "O" && C== "O")
                {
                    win = true;
                    Console.WriteLine(player2 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
                if (D == "O" && E == "O" && F == "O")
                {
                    win = true;
                    Console.WriteLine(player2 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
                if (G == "O" && H == "O" && I == "O")
                {
                    win = true;
                    Console.WriteLine(player2 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }

                //Check for Vertical Win
                if (A == "O" && D == "O" && G == "O")
                {
                    win = true;
                    Console.WriteLine(player2 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
                if (B == "O" && E == "O" && H == "O")
                {
                    win = true;
                    Console.WriteLine(player2 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
                if (C == "O" && F == "O" && I == "O")
                {
                    win = true;
                    Console.WriteLine(player2 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }

                //Check for Diagonal Win
                if (A == "O" && E == "O" && I == "O")
                {
                    win = true;
                    Console.WriteLine(player2 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
                if (C == "O" && E == "O" && G == "O")
                {
                    win = true;
                    Console.WriteLine(player2 + "wins!");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to play again? Y/N");
                    selection = Console.ReadLine();
                    if (selection == "y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }

               if (win == true)
                {


                    if (playAgain == true)
                    {
                        win = false;
                        playAgain = false;
                        turn = "Player1";
                        A = "1";
                        B = "2";
                        C = "3";
                        D = "4";
                        E = "5";
                        F = "6";
                        G = "7";
                        H = "8";
                        I = "9";
                        goto Start;

                    }
                    else if (playAgain == false)
                    {
                        Console.WriteLine("Thanks for playing");
                        Console.Read();
                    }
                }




            }

            if (win == false)
            {
                goto Start;
            }

            
        }

        

    }
}
