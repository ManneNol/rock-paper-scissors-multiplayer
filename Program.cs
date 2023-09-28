using rock_paper_scissors_multiplayer;

int playerCount = 2;
List<Player> players = new List<Player>();

for (int i = 1; i <= playerCount; i++)
{
    string name = string.Empty;
    while (name.Length == 0)
    {
        Console.Clear();
        Console.Write("Please enter the name of player " + i + ": ");
        name = Console.ReadLine() ?? string.Empty;
    }

    players.Add(new Player(name));
}

for (int i = 1; i <= 3; i++)
{
    foreach (Player player in players)
    {
        Console.Clear();
        Console.WriteLine("Round " + i);
        Console.Write("Players in game: ");
        Console.Write(player.Name + " ");
    }


    Console.ReadKey();
}