using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEntities
{
    public static class ConvertMoveEnumToString
    {
        public static string GetObjectName(EnMoveChoise moveChoice)
        {
            switch (moveChoice)
            {
                case EnMoveChoise.Paper:
                    return "Paper";

                case EnMoveChoise.Rock:
                    return "Rock";

                case EnMoveChoise.Scissors:
                    return "Scissors";

                default:
                    return "Unknown!";
                    
            }
        }
    }
}
