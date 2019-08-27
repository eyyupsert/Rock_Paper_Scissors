using GameEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDatas
{
    public class HumanMove:PlayerMove
    {
        public void AssigmentHumanMove(EnMoveChoise humanMove)
        {
            currentChoice = humanMove;
        }
    }
}
