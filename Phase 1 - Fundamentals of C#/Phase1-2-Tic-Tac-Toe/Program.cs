﻿
using System.Diagnostics.Metrics;

char? player1_choice = ' ', player2_choice = ' ';
Players player = new Players();
void getPlayer1Choice()
{
    while(true)
    {
        Console.Write("Player 1, choose X or O: ");
        player1_choice = char.Parse(Console.ReadLine());
        if (player1_choice == 'X' || player1_choice == 'O') break;
        else Console.WriteLine("Error!, Enter X or O");
    }
    
    Console.Clear();
}

getPlayer1Choice();
TicTacToeGame play = new TicTacToeGame(player1_choice);
Console.WriteLine($"Player 2, you are {play.GetPlayer2Choice()}");
Console.ReadKey();
Console.Clear();

play.DisplayBoard();

while(true)
{

    if (getPlayer1Square() == false || getPlayer2Square() == false)
    {
        Console.WriteLine("The game has ended as a draw!");
        break;
    }
    else continue;
}


    




bool getPlayer1Square()
{
    int count1 = 0;
    Console.Write("\n\nPlayer 1, choose the square you want to play in using numbers 1 to 9: ");
    int player1_square = int.Parse(Console.ReadLine());
    if (play.UpdateBoard(player1_square, Players.Player1) == false)
    {
        Console.WriteLine("This square is already occupied! Choose another square");
        for (int a = 1; a < 10; a++)
        {
            if (play.UpdateBoard(a, Players.Player1) == false) count1++;
        }
        if (count1 == 9) return false;
        else
        {
            getPlayer1Square();
        }
        
    }
    return true;
    
}

bool getPlayer2Square()
{
    int count2 = 0;
    Console.Write("\n\nPlayer 2, choose the square you want to play in using numbers 1 to 9: ");
    int player2_square = int.Parse(Console.ReadLine());
    if (play.UpdateBoard(player2_square, Players.Player2) == false)
    {
        Console.WriteLine("This square is already occupied! Choose another square");
        for (int a = 1; a < 10; a++)
        {
            if (play.UpdateBoard(a, Players.Player2) == false) count2++;
        }
        if (count2 == 9) return false;
        else
        {
            getPlayer2Square();
        }
    }
    return true;

}
    


Console.ReadKey();


class TicTacToeGame {

    public char Player1 { get; }
    public char Player2 { get; private set; }
    public int Player1Square { get; }
    public int Player2Square { get; }
    public Players Player { get; }

    public char[,] Board { get; }

    public TicTacToeGame(char? player1)
    {
        Player1 = (char)player1;

        Board = new char[3, 3]
            {
                { '7', '8', '9' },
                { '4', '5', '6' },
                { '1', '2', '3' }
            };
    }

    public char GetPlayer2Choice()
    {
        switch (Player1)
        {
            case 'X':
                Player2 = 'O';
                break;
            case 'O':
                Player2 = 'X';
                break;
            default:
                Console.WriteLine("Error!, enter X or O");
                break;
        }
        return Player2;
    }
    
    public void DisplayBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(" " + Board[i, j] + " ");
                if (j < 2)
                    Console.Write("|");
            }
            if (i < 2)
            {
                Console.WriteLine("\n---+---+---");
            }
        }
        Console.WriteLine();
    }

    

    public bool UpdateBoard(int playerSquare, Players Player)
    {
        switch(playerSquare)
        {
            case 1:
                if (Board[2, 0] == Player1 || Board[2, 0] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[2, 0] = Player1;
                    if (Player == Players.Player2) Board[2, 0] = Player2;
                }
                break;
            case 2:
                if (Board[2, 1] == Player1 || Board[2, 1] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[2, 1] = Player1;
                    if (Player == Players.Player2) Board[2, 1] = Player2;
                }
                break;
            case 3:
                if (Board[2, 2] == Player1 || Board[2, 2] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[2, 2] = Player1;
                    if (Player == Players.Player2) Board[2, 2] = Player2;
                }
                break;
            case 4:
                if (Board[1, 0] == Player1 || Board[1, 0] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[1, 0] = Player1;
                    if (Player == Players.Player2) Board[1, 0] = Player2;
                }
                break;
            case 5:
                if (Board[1, 1] == Player1 || Board[1, 1] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[1, 1] = Player1;
                    if (Player == Players.Player2) Board[1, 1] = Player2;
                }
                break;
            case 6:
                if (Board[1, 2] == Player1 || Board[1, 2] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[1, 2] = Player1;
                    if (Player == Players.Player2) Board[1, 2] = Player2;
                }
                break;
            case 7:
                if (Board[0, 0] == Player1 || Board[0, 0] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[0, 0] = Player1;
                    if (Player == Players.Player2) Board[0, 0] = Player2;
                }
                break;
            case 8:
                if (Board[0, 1] == Player1 || Board[0, 1] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[0, 1] = Player1;
                    if (Player == Players.Player2) Board[0, 1] = Player2;
                }
                break;
            case 9:
                if (Board[0, 2] == Player1 || Board[0, 2] == Player2) return false;
                else
                {
                    if (Player == Players.Player1) Board[0, 2] = Player1;
                    if (Player == Players.Player2) Board[0, 2] = Player2;
                }
                break;

        }
        Console.WriteLine("\n");
        DisplayBoard();
        return true;
    }

    //public void checkForXWin()
    //{
    //    for (int i = 0; i < 3; i++)
    //    {
    //        for (int j = 0; j < 3; j++)
    //        {
    //            if (Board[i, j] == 'X' && Board[i + 1, j + 1] == 'X' && Board[i + 2, j + 2] == 'X')

    //            if (Board[i, j] == 'X' && Board[i, j + 1] == 'X' && Board[i, j + 2] == 'X' )
    //            if (Board[i + 1, j] == 'X' && Board[i + 1, j + 1] == 'X' && Board[i + 1 , j + 2] == 'X')
    //            if (Board[i + 2, j] == 'X' && Board[i + 2, j + 1] == 'X' && Board[i + 2, j + 2] == 'X')

    //            if (Board[i, j] == 'X' && Board[i + 1, j] == 'X' && Board[i + 2, j] == 'X')
    //            if (Board[i, j + 1] == 'X' && Board[i + 1, j + 1] == 'X' && Board[i + 2, j + 1] == 'X')
    //            if (Board[i, j + 2] == 'X' && Board[i + 1, j + 2] == 'X' && Board[i + 2, j + 2] == 'X')

             
    //        }
    //    }
     
    //}


}

enum Players { Player1, Player2 }

