// See https://aka.ms/new-console-template for more information

//var numberOfSimulation = 100;

using System.Threading.Channels;
using RockPaperScissorsAssignment;

namespace RPSGame
{
    public enum ChoiceStrategy
    {
        None = 0,
        Rock = 1,
        Paper = 2,
        Scissors = 3
    }

    enum ContinueSimulationEnum
    {
        Yes = 0,
        No = 1
    }

    public enum GameResult
    {
        Draw = 0,
        Win = 1,
        Lose = 2
    }
    public class Game
    {
        public static void Main()
        {
            int numberOfSimulation = 100;
            var contiueGame = ContinueSimulationEnum.Yes;
            //var computerStrategy = ChoiceStrategy.Rock;
            var computerStrategy = FactoryMethod.CreateStrategy(ChoiceStrategy.Rock);
            for (int i = 0; i < numberOfSimulation && contiueGame == ContinueSimulationEnum.Yes; i++)
            {
                Console.WriteLine($"Simulation Turn:{i + 1}");
                var userStrategy = ChoiceStrategy.None;
                do
                {
                    Console.Write("\r\nChoose Your Option( 1)Rock 2)Paper 3)Scissors ):");
                    userStrategy = SelectStrategy(Console.ReadKey().Key);
                } while (userStrategy == ChoiceStrategy.None);

                Console.WriteLine();
                var result = computerStrategy.FindWinner(userStrategy);
                if (result == GameResult.Win)
                {
                    Console.WriteLine("Computer Wins");
                }else if (result == GameResult.Lose)
                {
                    Console.WriteLine("Computer Loses");
                }
                else
                {
                    Console.WriteLine("DRAW!!");
                }
                Console.Write("Would You like to contiune(Y/N):");
                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    contiueGame = ContinueSimulationEnum.No;
                }

                Console.WriteLine("\r\n----------------------------------------");
            }
            Console.WriteLine("\r\n Game Finished");
        }

        private static string FindWinner(ChoiceStrategy compStrategy , ChoiceStrategy userStrategy)
        {
            var resultMessage = "";
            

            return resultMessage;
        }

        private static ChoiceStrategy SelectStrategy( ConsoleKey key)
        {
            var choice = key switch
            {
                ConsoleKey.D1 => ChoiceStrategy.Paper,
                ConsoleKey.D2 => ChoiceStrategy.Rock,
                ConsoleKey.D3 => ChoiceStrategy.Scissors,
                _ => ChoiceStrategy.None
            };
            return choice;
        }
    }
}



