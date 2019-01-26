using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Constants
{
    public static class DiceConstants
    {
        // Minimum number of a standard Dice
        public const int MinStandard = 1;
        // Maximum number of a standard Dice 
        public const int MaxStandart = 6;

        // The user will be able to throw dice 2 times if all of the 4 pawns are at home fields 
        public const int ThrowsIfAllAtHome = 2;
    }
}
