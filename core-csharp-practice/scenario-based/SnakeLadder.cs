using System;

class SnakeAndLadder
{
    static string[] playerNames;
    static int[] playerPositions;
    static int playerCount;
    static int[] from = { 4, 9, 17, 20, 28, 40, 51, 54, 62, 64, 71, 87, 93, 95, 99 };
    static int[] to = { 14, 31, 7, 38, 84, 59, 67, 34, 19, 60, 91, 24, 73, 75, 78 };

    //Random gives random number within the specified range
    static Random random = new Random();

    static int RollDice()
    {
        return random.Next(1, 7);
    }

    static int ApplySnakeOrLadder(int position)
    {
        for (int i = 0; i < from.Length; i++)
        {
            if (from[i] == position)
                return to[i];
        }
        return position;
    }

    static void StartGame()
    {
        while (true)
        {
            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine($"\n{playerNames[i]}'s turn. Press ENTER to roll dice."); //$It is used for string interpolation
                Console.ReadLine();
                int dice = RollDice();
                int oldPos = playerPositions[i];
                int nextPos = oldPos + dice;

                if (nextPos > 100)
                {
                    Console.WriteLine($"{playerNames[i]} rolled {dice}. Move skipped.");
                    continue;
                }

                nextPos = ApplySnakeOrLadder(nextPos);
                playerPositions[i] = nextPos;

                Console.WriteLine($"{playerNames[i]} rolled {dice}");
                Console.WriteLine($"Position: {oldPos} → {nextPos}");

                if (nextPos == 100)
                {
                    Console.WriteLine($"\n🏆 {playerNames[i]} wins!");
                    return;
                }
            }
        }
    }
    static void Main()
    {
        Console.Write("Enter number of players (2–4): ");
        playerCount = int.Parse(Console.ReadLine());

        if (playerCount < 2 || playerCount > 4)
        {
            Console.WriteLine("Invalid player count."); //If player count is less than 2 or greater than 4, print invalid player count and return
            return;
        }

        playerNames = new string[playerCount];
        playerPositions = new int[playerCount];

        for (int i = 0; i < playerCount; i++)
        {
            Console.Write($"Enter name for Player {i + 1}: ");
            playerNames[i] = Console.ReadLine();
            playerPositions[i] = 0;
        }

        StartGame();
    }
}