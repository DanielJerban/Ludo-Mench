using Ludo.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo.Models.Game
{
    // Delegate Declaed 
    public delegate void GameStateChanged(object sender, EventArgs e);

    public partial class Game : Form
    {
        // Changes the game state 
        private void TriggerStateChange()
        {
            OnStateChanged?.Invoke(this, EventArgs.Empty);
        }

        public GameStateType GameState
        {
            get
            {
                return this.gameState;
            }
            set
            {
                this.gameState = value;
                this.TriggerStateChange();
            }
        }

        private void GameStateHub(object sender, EventArgs e)
        {
            switch(this.GameState)
            {
                case GameStateType.InitPlayerTurn:
                    {
                        this.DoInitPlayerTurn();
                        break;
                    }
                case GameStateType.ChangePlayerTurn:
                    {
                        this.DoChangePlayerTurn();
                        break;
                    }
                case GameStateType.MovePawn:
                    {
                        this.DoMovePawn(this.currentPlayer);
                        break;
                    }
                case GameStateType.ThrowNormal:
                    {
                        this.DoThrowNormal();
                        break;
                    }
                case GameStateType.SelectPawn:
                    {
                        this.DoSelectPawn(this.currentPlayer);
                        break;
                    }
            }
        }
    }
}
