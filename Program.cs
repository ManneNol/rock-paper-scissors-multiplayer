using rock_paper_scissors_multiplayer;

int playerCount = 2; // the amount of players we want in our game
List<Player> players = new List<Player>(); // list of all our players

for (int i = 1; i <= playerCount; i++) // loop for creating each player
{
    string name = string.Empty;
    // asks the player for their name until it's not empty
    while (name.Length == 0)
    {
        Console.Clear();
        Console.Write("Please enter the name of player " + i + ": ");
        name = Console.ReadLine() ?? string.Empty; // ?? to handle null case
    }

    // creates a new player and adds them to the list with their selected name
    players.Add(new Player(name));
}

// Game Loop
// Plays 3 rounds
for (int round = 1; round <= 3; round++)
{
    // Loop describing each players round where they pick what to play
    foreach (Player player in players)
    {
        Console.Clear();
        DisplayGameState(round); // prints out the current round
        player.PickOption(); // calls the method that lets the player make a choice
    }

    Console.Clear();
    DisplayGameState(round);

    foreach (Player player in players)
    {
        Console.WriteLine("Player " + player.Name + " chose: " + player.Choice);
    }

    Console.WriteLine("Player " + players[0].Name + " has ended the round with a " +
                      CalculateOutcome(players[0], players[1]));
    Console.ReadKey();
}

Outcome CalculateOutcome(Player p1, Player p2)
{
    switch (p1.Choice)
    {
        case Option.Rock:
            switch (p2.Choice)
            {
                case Option.Rock: return Outcome.Draw;
                case Option.Paper: return Outcome.Loss;
                case Option.Scissor: return Outcome.Win;
            }

            break;
        case Option.Paper:
            switch (p2.Choice)
            {
                case Option.Rock: return Outcome.Win;
                case Option.Paper: return Outcome.Draw;
                case Option.Scissor: return Outcome.Loss;
            }

            break;
        case Option.Scissor:
            switch (p2.Choice)
            {
                case Option.Rock: return Outcome.Loss;
                case Option.Paper: return Outcome.Win;
                case Option.Scissor: return Outcome.Draw;
            }

            break;
    }

    throw new InvalidOperationException();
}

void DisplayGameState(int round)
{
    Console.WriteLine("--- Round " + round + " ---");
    Console.Write("Players in game: ");
    foreach (Player player in players)
    {
        Console.Write(player.Name + " ");
    }

    Console.WriteLine();
}