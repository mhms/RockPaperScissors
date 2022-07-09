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
            var playerA = StrategyFactoryMethod.Create(ChoiceStrategy.Rock);
            var statDictionary = new Dictionary<GameResult, int>();
            statDictionary.Add(GameResult.Win,0);
            statDictionary.Add(GameResult.Draw,0);
            statDictionary.Add(GameResult.Lose,0);
            for (int i = 0; i < numberOfSimulation /*&& contiueGame == ContinueSimulationEnum.Yes*/; i++)
            {
                Console.WriteLine($"Simulation Turn:{i + 1}");
                var userStrategy = ChoiceStrategy.None;
                do
                {
                    Console.Write("\r\nChoose Your Option( 1)Rock 2)Paper 3)Scissors ):");
                    //userStrategy = SelectStrategy(Console.ReadKey().Key);
                    Random r = new Random();
                    var randIntValue = r.Next(3) + 1;
                    Console.WriteLine(randIntValue);
                    userStrategy = SelectStrategy((randIntValue));
                } while (userStrategy == ChoiceStrategy.None);

                //Console.WriteLine();
                var result = playerA.FindWinner(userStrategy);
                statDictionary[result]++;
                PrintResult(result);

                //ConsoleKey continueKey;
                //do
                //{
                //    Console.Write("Would You like to contiune(Y/N):");
                //    continueKey = Console.ReadKey().Key;
                //    if (continueKey == ConsoleKey.N)
                //    {
                //        contiueGame = ContinueSimulationEnum.No;
                //    }
                //    Console.WriteLine();
                //} while (continueKey != ConsoleKey.Y && continueKey != ConsoleKey.N);

                Console.WriteLine("\r\n----------------------------------------");
            }

            Console.WriteLine($"No wins:{statDictionary[GameResult.Win]}");
            Console.WriteLine($"No draws:{statDictionary[GameResult.Draw]}");
            Console.WriteLine($"No loses:{statDictionary[GameResult.Lose]}");
            Console.WriteLine("\r\n Game Finished");
        }

        private static void PrintResult(GameResult result)
        {
            if (result == GameResult.Win)
            {
                Console.WriteLine("PlayerA Wins");
            }
            else if (result == GameResult.Lose)
            {
                Console.WriteLine("PlayerA Loses");
            }
            else
            {
                Console.WriteLine("Draw!!");
            }
        }

    
        private static ChoiceStrategy SelectStrategy( int key)
        {
            var choice = key switch
            {
                2 => ChoiceStrategy.Paper,
                1 => ChoiceStrategy.Rock,
                3 => ChoiceStrategy.Scissors,
                _ => ChoiceStrategy.None
            };
            return choice;
        }
    }
}



