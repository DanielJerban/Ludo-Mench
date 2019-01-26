using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Contracts
{
    interface IDice
    {
        // Minimum number of the Dice 
        int MinNum { get; }
        // Maximum number of a dice 
        int MaxNum { get; }

        // Throw Dice Function 
        int Throw(Random rnd);
    }
}
