using Ludo.Constants;
using Ludo.Enumerations;
using Ludo.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo.Models.Game
{
    public partial class Game : Form
    {
        /// <summary>
        /// Setting initial player turn 
        /// </summary>
        private void DoInitPlayerTurn()
        {
            this.currentPlayer = this.players[turn];

            // Setting lblTurn current player name and color 
            this.lblTurn.Text = this.currentPlayer.Name;
            this.lblTurn.BackColor = ColorConstants.Colors[(int)this.currentPlayer.Color];
            // Dice number text 
            this.lblStandart.Text = "";

            // Shows pawn escaped count 
            this.lblEscapedCount.Text = $"x{currentPlayer.PawnsEscaped}";

            pbEscapedPawn.BackgroundImage =
                // Simplized if and else by using '?' and ':' 
                // By defualt it is Red Pawn 
                currentPlayer.Color == ColorType.Red ? Ludo.Properties.Resources.PawnRed :
                currentPlayer.Color == ColorType.Green ? Ludo.Properties.Resources.PawnGreen :
                currentPlayer.Color == ColorType.Yellow ? Ludo.Properties.Resources.PawnYellow :
                currentPlayer.Color == ColorType.Blue ? Ludo.Properties.Resources.PawnBlue :
                    Ludo.Properties.Resources.PawnRed;

            this.UpdateControls(false);
            this.UpdatePawns(false, false);
            this.BringPawnsToFront();

            // There is no pawns in the playground fields 
            if (this.currentPlayer.PawnsAtHome + this.currentPlayer.PawnsEscaped == PlayerConstants.PawnsPerPlayer)
            {
                this.curPlayerInitialThrows = DiceConstants.ThrowsIfAllAtHome;
            }

            // Game state changes to Throw Dice 
            this.GameState = GameStateType.ThrowNormal;
        }

        /// <summary>
        /// Changes player turn 
        /// </summary>
        private void DoChangePlayerTurn()
        {
            // increamenting turn number 
            this.turn++;

            // Handling Turn number between 0 to 3 
            if (this.turn >= this.playerCount)
            {
                this.turn = 0;
            }

            // Game state changes to Init Player turn 
            this.GameState = GameStateType.InitPlayerTurn;
        }

        private void DoSelectPawn(Player p)
        {
            this.UpdateControls(false);
            this.UpdatePawns(true, false);
        }

        private async void DoMovePawn(Player p)
        {
            // Selecting a pawn from home fields 
            Pawn pawn = p.Pawns[p.SelectedPawn];

            bool atHome = pawn.IsAtHome;
            // Checking if there is a pawn in that home field
            if (atHome)
            {
                // Reducing pawns at home by one 
                pawn.CurrentField.HasPawn = false;
                p.PawnsAtHome--;
            }
            else
            {
                pawn.CurrentField.HasPawn = this.IsFieldStillPopulated(pawn.CurrentField);
            }

            pawn.Move(this.playground, GetFinishFromColor(pawn.Color), Math.Abs(p.StepsLeft));

            // If the pawn ain't at home 
            if (!atHome)
                // Delay for a moment 
                await Task.Delay((Math.Abs(p.StepsLeft) * PawnConstants.DisplayDelay));

            p.StepsLeft = 0;

            this.HandleNewPawnPosition(pawn);
        }

        private void DoThrowNormal()
        {
            this.UpdateControls(true);
            this.UpdatePawns(false, false);
        }
    }
}
