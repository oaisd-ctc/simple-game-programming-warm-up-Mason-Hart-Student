using System;

class Program
{
    static int[] diceNums = {1, 2, 3, 4, 5, 6};
    static int playerNum;
    static int rivalNum;
    static int playerScore;
    static int rivalScore;
    static int Round = 1;
    static int rolledNum;
    public static void Main(string[] args)
    {
        Beginning();
    }

    public static void Beginning()
    {
        Console.WriteLine("Dice Game");
        Console.WriteLine();
        Console.WriteLine("In this game you and a computer Rival will play 10 rounds\nwhere you will each roll a 6-sided dice, and the player\nwith the highest dice value will win the round. The player\nwho wins the most rounds wins the game. Good luck!");
        Console.WriteLine();
        Console.WriteLine("Press any key to start...");
        Console.ReadKey();
        Console.Write("\b \b");
        RivalRolled();
    }

    public static void RivalRolled()
    {
        Random randum = new Random();
        int i = randum.Next(diceNums.Count());
        rolledNum = diceNums[i];
        rivalNum = rolledNum;
        Console.WriteLine();
        Console.WriteLine($"Round {Round}");
        Console.WriteLine($"Rival rolled a {rolledNum}");
        Console.WriteLine("Press any key to roll the dice...");
        Console.ReadKey();
        Console.Write("\b \b");
        PlayerRolled();
    }
    public static void PlayerRolled()
    {
        Round ++;
        Random randum = new Random();
        int i = randum.Next(diceNums.Count());
        rolledNum = diceNums[i];
        playerNum = rolledNum;
        Console.WriteLine($"You rolled a {rolledNum}");
        if(playerNum > rivalNum)
        {
            Console.WriteLine("You won this round.");
            playerScore ++;
        }
        else if(rivalNum > playerNum)
        {
            Console.WriteLine("The Rival won this round.");
            rivalScore ++;
        }
        else if(rivalNum == playerNum)
        {
            Console.WriteLine("This round is a draw!");
        }
        Console.WriteLine($"The score is now - You : {playerScore}. Rival : {rivalScore}.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Write("\b \b");
        if(Round > 10)
        {
            Ending();
        }
        else
        {
            RivalRolled();
        }
    }
    public static void Ending()
    {
        Console.WriteLine();
        Console.WriteLine("Game over.");
        Console.WriteLine($"The score is now - You: {playerScore}. Rival : {rivalScore}.");
        if(playerScore > rivalScore)
        {
            Console.WriteLine("You won!");
        }
        else if(rivalScore > playerScore)
        {
            Console.WriteLine("You lost!");
        }
        else if(rivalScore == playerScore)
        {
            Console.WriteLine("You tied!");
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        Console.Write("\b \b");
        Console.Clear();
        Console.WriteLine("Dice Game was closed.");
    }
}