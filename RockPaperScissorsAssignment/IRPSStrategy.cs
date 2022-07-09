namespace RPSGame;

public interface IRPSStrategy
{
    public GameResult FindWinner(ChoiceStrategy secondUser);
}