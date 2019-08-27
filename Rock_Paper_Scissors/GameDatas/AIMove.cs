using GameEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDatas
{
    public class AIMove:PlayerMove
    {
        Random randomFinder = new Random();
        

        public void DoAIMove()
        {
           FindAIMove(randomFinder.Next(0,2));
        }

        private void FindAIMove(int moveNumber)
        {        
            switch (moveNumber)
            {
                case 0:
                    currentChoice = EnMoveChoise.Rock;
                    break;
                case 1:
                    currentChoice = EnMoveChoise.Paper;
                    break;
                case 2:
                    currentChoice = EnMoveChoise.Scissors;
                    break;
                default:
                    currentChoice = EnMoveChoise.Unknown;
                    break;
            }
        }

    }
}
