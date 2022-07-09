using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPSGame;

namespace RockPaperScissorsAssignment
{
    internal class RockStrategy: IRPSStrategy
    {
        public GameResult FindWinner(ChoiceStrategy secondUser)
        {
            if (secondUser == ChoiceStrategy.Paper)
            {
                return GameResult.Lose;
            }
            else if (secondUser == ChoiceStrategy.Rock)
            {
                return GameResult.Draw;
            }
            else
            {
                return GameResult.Win;
            }
        }
    }
}
