using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPSGame;

namespace RockPaperScissorsAssignment
{
    public class ScissorsStrategy: IRPSStrategy
    {
        public GameResult FindWinner(ChoiceStrategy secondUser)
        {
            if (secondUser == ChoiceStrategy.Paper)
            {
                return GameResult.Win;
            }
            else if (secondUser == ChoiceStrategy.Rock)
            {
                return GameResult.Lose;
            }
            else
            {
                return GameResult.Draw;
            }
        }
    }
}
