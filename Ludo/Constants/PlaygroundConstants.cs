using System.Collections.Generic;

namespace Ludo.Constants
{
    public static class PlaygroundConstants
    {
        // The starting field number for each color 
        public static readonly int[] PlayerStartPos =
        {
            0,  // Red 
            10, // Blue 
            20, // Yellow 
            30  // Green 
        };

        // The entry field number for each color 
        public static readonly int[] PlayerEntryToFinish =
        {
            39, // Red 
            9,  // Blue 
            19, // Yellow
            29  // Green 
        };

        // Total playground main field count 
        public const int PlaygroundSize = 40;

        // The number of Finish field for each player 
        public const int FinishSize = 4;
    }
}
