using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ludo.Constants;
using Ludo.Enumerations;
using System.IO;

namespace Ludo.Models
{
    public static class Playground
    {
        // A list of fields craetes the playground 
        private static IList<Field> playground;
        // A list of fields craetes the Red finish part 
        private static IList<Field> redFinish;
        // A list of fields craetes the Green finish part 
        private static IList<Field> greenFinish;
        // A list of fields craetes the Yellow finish part 
        private static IList<Field> yellowFinish;
        // A list of fields craetes the Blue finish part 
        private static IList<Field> blueFinish;

        /// <summary>
        /// Creating the playground 
        /// </summary>
        static Playground()
        {
            // Creates the playground with size = 40 
            playground = new List<Field>(PlaygroundConstants.PlaygroundSize);

            // Creates the finish part with size = 4  
            redFinish = new List<Field>(PlaygroundConstants.FinishSize);
            greenFinish = new List<Field>(PlaygroundConstants.FinishSize);
            yellowFinish = new List<Field>(PlaygroundConstants.FinishSize);
            blueFinish = new List<Field>(PlaygroundConstants.FinishSize);

            // Setting the fields position by pixels and numbers 
            /*
              PAY ATTENTION : it is super hard to organize the playground plz do not try to change it 
                              otherwise the game will be broken 
            */
            var dict = new Dictionary<int, string>()
            {
                /*
                 The first value in the string part is Field Type,
                 The second value in the string part is X Position,
                 And the third value is Y Position 
                 */
                 // The integer part is the number of the field  
                { 0, "2 403 18"   }, { 1, "0 403 62"   }, { 2, "0 403 106"  }, { 3, "0 403 150"  },
                { 4, "0 403 194"  }, { 5, "0 447 194"  }, { 6, "0 491 194"  }, { 7, "0 535 194"  },
                { 8, "0 579 194"  }, { 9, "0 579 238"  }, { 10, "2 579 282" }, { 11, "0 535 282" },
                { 12, "0 491 282" }, { 13, "0 447 282" }, { 14, "0 403 282" }, { 15, "0 403 326" },
                { 16, "0 403 370" }, { 17, "0 403 414" }, { 18, "0 403 460" }, { 19, "0 359 460" },
                { 20, "2 315 460" }, { 21, "0 315 416" }, { 22, "0 315 372" }, { 23, "0 315 328" },
                { 24, "0 315 284" }, { 25, "0 271 284" }, { 26, "0 227 284" }, { 27, "0 183 284" },
                { 28, "0 139 284" }, { 29, "0 139 240" }, { 30, "2 139 196" }, { 31, "0 183 196" },
                { 32, "0 227 196" }, { 33, "0 271 196" }, { 34, "0 315 196" }, { 35, "0 315 152" },
                { 36, "0 315 108" }, { 37, "0 315 64"  }, { 38, "0 315 20"  }, { 39, "0 359 20"  },

                //red finish
                { 40, "1 359 64" }, { 41, "1 359 108" }, { 42, "1 359 152" }, { 43, "1 359 196" },
                //green finish
                { 44, "1 183 240" }, { 45, "1 227 240" }, { 46, "1 271 240" }, { 47, "1 315 240" },
                //yellow finish                                                     
                { 48, "1 359 416" }, { 49, "1 359 372" }, { 50, "1 359 328" }, { 51, "1 359 284" },
                //blue finish                                                       
                { 52, "1 535 238" }, { 53, "1 491 238" }, { 54, "1 447 238" }, { 55, "1 403 238" }
            };

            // An array with 3 spaces 
            int[] fParams = new int[3];

            // Adding playground fields 
            for (int i = 0; i < dict.Count; i++)
            {
                fParams = dict[i].Split(' ').Select(int.Parse).ToArray();

                // Red finish fields 
                if (i >= 40 && i <= 43)
                {
                    redFinish.Add(new Field((FieldType)fParams[0], fParams[1], fParams[2]));
                }

                // Green finish fields 
                else if(i >= 44 && i <= 47)
                {
                    greenFinish.Add(new Field((FieldType)fParams[0], fParams[1], fParams[2]));
                }

                // Yellow finish fields 
                else if(i >= 48 && i <= 51)
                {
                    yellowFinish.Add(new Field((FieldType)fParams[0], fParams[1], fParams[2]));
                }

                // Blue finish fields 
                else if(i >= 52 && i <= 55)
                {
                    blueFinish.Add(new Field((FieldType)fParams[0], fParams[1], fParams[2]));
                }

                // Playground fields 
                else
                {
                    playground.Add(new Field((FieldType)fParams[0], fParams[1], fParams[2]));
                }
            }
        }
        
        // Helper method to return the playground 
        public static IList<Field> GetPlayground()
        {
            return playground;
        }

        // Returns a list of finish fields  ????????????????????????????/
        public static IList<Field> GetFinish(ColorType color)
        {
            switch(color)
            {
                case ColorType.Red:
                    return redFinish;
                case ColorType.Green:
                    return greenFinish;
                case ColorType.Yellow:
                    return yellowFinish;
                case ColorType.Blue:
                    return blueFinish;
                default:
                    return redFinish; 
            }
        }
    }
}
