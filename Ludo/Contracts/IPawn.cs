using Ludo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Contracts
{
    interface IPawn
    {
        /// <summary>
        /// Move Pawn step by step 
        /// </summary>
        /// <param name="playground">A list of playground fields</param>
        /// <param name="finish">A list of finish fields</param>
        /// <param name="steps">Moving steps count which is equal to the Dice number</param>
        void Move(IList<Field> playground, IList<Field> finish, int steps);
    }
}
