using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPSGame;

namespace RockPaperScissorsAssignment
{
    internal class PaperStrategy: IRPSStrategy
    {
        public GameResult FindWinner(ChoiceStrategy secondUser)
        {
            if (secondUser == ChoiceStrategy.Paper)
            {
                return GameResult.Draw;
            }
            else if (secondUser == ChoiceStrategy.Rock)
            {
                return GameResult.Win;
            }
            else
            {
                return GameResult.Lose;
            }
        }
    }
}
