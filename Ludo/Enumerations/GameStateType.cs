using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Enumerations
{
    // an enumeration of the game state types
    public enum GameStateType
    {
        ThrowNormal,
        SelectPawn,
        MovePawn,
        InitPlayerTurn,
        ChangePlayerTurn,
    }
}
