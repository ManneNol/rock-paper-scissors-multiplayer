namespace rock_paper_scissors_multiplayer;

public class Player
{
    public readonly string Name;
    public Option Choice;

    public Player(string name)
    {
        Name = name;
    }

    public void PickOption()
    {
        bool validInput;
        do
        {
            validInput = true;
            Console.WriteLine("Player " + Name + ", Please select rock, paper or scissor");
            switch (Console.ReadLine()?.ToLower())
            {
                case "rock":
                case "r":
                    Choice = Option.Rock;
                    break;
                case "paper":
                case "p":
                    Choice = Option.Paper;
                    break;
                case "scissor":
                case "s":
                    Choice = Option.Scissor;
                    break;
                default:
                    validInput = false;
                    break;
            }
        } while (!validInput);
    }
}