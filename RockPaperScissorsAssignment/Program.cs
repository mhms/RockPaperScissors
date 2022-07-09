// See https://aka.ms/new-console-template for more information

//var numberOfSimulation = 100;

using System.Threading.Channels;

namespace RPSGame
{
    enum ChoiceStrategy
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
    public class Game
    {
        public static void Main()
        {
            int numberOfSimulation = 100;
            var contiueGame = ContinueSimulationEnum.Yes;
            for (int i = 0; i < numberOfSimulation && contiueGame == ContinueSimulationEnum.Yes; i++)
            {
                Console.WriteLine($"Simulation Turn:{i + 1}");
                var selectedStrategy = ChoiceStrategy.None;
                do
                {
                    Console.Write("\r\nChoose Your Option( 1)Rock 2)Paper 3)Scissors ):");
                    selectedStrategy = SelectStrategy(Console.ReadKey().Key);
                } while (selectedStrategy == ChoiceStrategy.None);

                Console.WriteLine();
                if (selectedStrategy == ChoiceStrategy.Paper)
                {
                    Console.WriteLine("User Loses");
                }else if (selectedStrategy == ChoiceStrategy.Rock)
                {
                    Console.WriteLine("User and Computer Draw");
                }
                else if (selectedStrategy == ChoiceStrategy.Scissors)
                {
                    Console.WriteLine("User Wins");
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



