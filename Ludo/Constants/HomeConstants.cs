using System;
using System.Collections.Generic;
using System.Drawing;
namespace Ludo.Constants
{
    public static class HomeConstants
    {
        // The free space between the center of each home filed to the currect position 
        public static readonly int OffsetFromOrigin = 36;

        // The center home position for each color in the X side 
        public static readonly int[] HomeOriginX =
        {
            512, //red
            512, //green
            203, //yellow
            203  //blue
        };

        // The center home position for each color in the Y side 
        public static readonly int[] HomeOriginY =
        {
            85, //red
            394, //green
            394, //yellow
            85  //blue
        };
    }
}
