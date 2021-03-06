using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPSGame;

namespace RockPaperScissorsAssignment
{
    public class StrategyFactoryMethod
    {
        public IRPSStrategy RPSStrategy { get; set; }

        public static IRPSStrategy? Create(ChoiceStrategy choice)
        {
            return choice switch
            {
                ChoiceStrategy.Paper => new PaperStrategy(),
                ChoiceStrategy.Rock => new RockStrategy(),
                ChoiceStrategy.Scissors => new ScissorsStrategy(),
                _ => null
            };
        }
    }
}
