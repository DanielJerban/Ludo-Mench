using Ludo.Constants;
using Ludo.Enumerations;
using Ludo.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        /// Displays new pawns in the spesifice position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DisplayNewPawnPos(object sender , EventArgs e)
        {
            // Temp pawn instead of sender 
            Pawn p = sender as Pawn;

            // Search in all controls in the form 
            foreach (Control C in this.Controls)
            {
                if (C is Button && C.Name == p.PawnName)
                {
                    // Pawn location 
                    C.Location = new Point(p.CurrentField.XPos, p.CurrentField.YPos);
                }
            }
        }

        /// <summary>
        /// Pawn Click event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandlePawnClick(object sender, EventArgs e)
        {
            //Temp Button instead of sender 
            Button b = sender as Button;

            if (b != null)
            {
                // Selecting the selected pawn 
                this.currentPlayer.SelectedPawn = this.currentPlayer.Pawns.IndexOf(FindPawnFromControl(b));

                // Saving the selected pawn number as a Pawn 
                Pawn selected = this.currentPlayer.Pawns[this.currentPlayer.SelectedPawn];

                /* IF
                 * 1. Selected pawn is at home and 
                 * 2. Current player steps left < 6 and 
                 * 3. Current player pawns at home + pawns escaped < 4
                 */
                if (selected.IsAtHome && this.currentPlayer.StepsLeft < DiceConstants.MaxStandart
                    && this.currentPlayer.PawnsAtHome + this.currentPlayer.PawnsEscaped < PlayerConstants.PawnsPerPlayer)
                {
                    // Error occured 
                    // There is not enough pawn for the player 
                    return;
                }

                // Setting gamestate on the moving pawn 
                this.GameState = GameStateType.MovePawn;
            }
        }

        // Dice click event 
        private void HandleDiceClick(object sender, EventArgs e)
        {
            //Temp Button instead of sender 
            Button b = sender as Button;

            if (b == null)
                return;

            // We use switch case so we can use braek key word 
            switch (b.Name)
            {
                case "btnDiceStandart":
                    {
                        int val = this.diceStandart.Throw(rnd);
                        this.lblStandart.Text = $"{val}";
                        // Checking if there is any pawn in the playground 
                        if (val < DiceConstants.MaxStandart && currentPlayer.PawnsAtHome + currentPlayer.PawnsEscaped == PlayerConstants.PawnsPerPlayer)
                        {

                            if (this.curPlayerInitialThrows > 1)
                            {
                                this.curPlayerInitialThrows--;
                                this.GameState = GameStateType.ThrowNormal;

                            }
                            else
                            {
                                this.curPlayerInitialThrows--;
                                this.GameState = GameStateType.ChangePlayerTurn;
                            }

                            break;
                        }

                        this.players[turn].StepsLeft = val;

                        this.GameState = GameStateType.SelectPawn;
                        break;
                    }
            }
        }

        // Dice Enabled Changed Event 
        // Changing the dice background image 
        private void DiceEnabledChanged(object sender, EventArgs e)
        {
            // Temp button instead of sender 
            Button b = sender as Button;

            if (b == null)
                return;

            switch (b.Name)
            {
                case "btnDiceStandart":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.Standart :
                            global::Ludo.Properties.Resources.StandartDis;
                        break;
                    }
            }
        }

        /// <summary>
        /// Changing Dice enabled 
        /// </summary>
        /// <param name="standart">Dice Standard</param>
        public void UpdateControls(bool standart)
        {
            this.btnDiceStandart.Enabled = standart;
        }

        // Enable Player turn pawns 
        public void UpdatePawns(bool curPlayerPawns, bool enemyPawns)
        {
            bool enable = false;

            foreach (Control C in this.Controls)
            {
                if (C is Button)
                {
                    foreach (var plr in this.players)
                    {
                        enable = (plr == this.currentPlayer && curPlayerPawns)
                            || (plr != this.currentPlayer && enemyPawns);

                        //enable = (plr == currentPlayer && curPlayerPawnsEnabled);

                        foreach (var p in plr.Pawns)
                        {
                            if (C.Name == p.PawnName)
                            {
                                C.Enabled = enable;
                            }
                        }
                    }
                }
            }
        }
        // Hide Unused pawns for non players 
        public void HideUnusedPawns(ColorType color)
        {// Search between all Controls in the Form 
            foreach (Control C in this.Controls)
            {
                if (C is Button)
                {
                    for (int i = 0; i < PlayerConstants.PawnsPerPlayer; i++)
                    {
                        if (C.Name == $"{PawnConstants.PawnNames[(int)color]}{i}")
                        {
                            C.Hide();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// List of finish fields by Color 
        /// </summary>
        /// <param name="color">Color name </param>
        /// <returns></returns>
        public IList<Field> GetFinishFromColor(ColorType color)
        {
            return color == ColorType.Red ? redFinish :
                   color == ColorType.Green ? greenFinish :
                   color == ColorType.Yellow ? yellowFinish :
                   color == ColorType.Blue ? blueFinish : redFinish;
        }

        // Finds selected pawn from the availables pawn between all players  
        private Pawn FindPawnFromControl(Button b)
        {
            for (int i = 0; i < this.playerCount; i++)
            {
                for (int j = 0; j < PlayerConstants.PawnsPerPlayer; j++)
                {
                    if (this.players[i].Pawns[j].PawnName == b.Name)
                    {
                        return this.players[i].Pawns[j];
                    }
                }
            }

            return null;
        }

        private Button FindControlFromPawn(Pawn p)
        {
            foreach (Control C in this.Controls)
            {
                Button b = C as Button;

                if (b != null && b.Name == p.PawnName)
                {
                    return b;
                }
            }

            return null;
        }

        /// <summary>
        /// Brings the controller to front by z-order 
        /// </summary>
        private void BringPawnsToFront()
        {
            foreach (Control C in this.Controls)
            {
                if (C is Button && C.Name.Contains("Pawn"))
                {
                    C.BringToFront();
                }
            }
        }

        /// <summary>
        /// A player pawn hits an other player pawn 
        /// </summary>
        /// <param name="f">Field</param>
        /// <param name="exceptPawn">Pawn</param>
        private void RemovePawnsFromField(Field f, Pawn exceptPawn)
        {
            var indexOfField = this.playground.IndexOf(f);

            for (int i = 0; i < this.playerCount; i++)
            {
                for (int j = 0; j < PlayerConstants.PawnsPerPlayer; j++)
                {
                    // Selecting player pawn 
                    var pawn = this.players[i].Pawns[j];

                    if (exceptPawn == null ||
                        (pawn.PawnPos == indexOfField && !pawn.PawnIsInFinish
                        && pawn.Color != exceptPawn.Color && !pawn.IsAtHome))
                    {
                        this.BringPawnToHome(pawn);
                    }
                }
            }
        }

        /// <summary>
        /// Brings pawn to home field 
        /// </summary>
        /// <param name="p">Pawn</param>
        private void BringPawnToHome(Pawn p)
        {
            var pOwner = this.GetPawnOwner(p);

            p.CurrentField = pOwner.Home.FindEmptyHomeField();
            p.IsAtHome = true;
            pOwner.PawnsAtHome++;

        }

        /// <summary>
        /// Chcking if the field has pawn or not 
        /// </summary>
        /// <param name="f">Selected field</param>
        /// <returns></returns>
        private bool IsFieldStillPopulated(Field f)
        {
            var fieldIndex = this.playground.IndexOf(f);

            var count = 0;

            for (int i = 0; i < this.playerCount; i++)
            {
                for (int j = 0; j < PlayerConstants.PawnsPerPlayer; j++)
                {
                    Pawn p = this.players[i].Pawns[j];

                    if (p.PawnPos == fieldIndex
                        && !p.PawnIsInFinish && !p.IsAtHome)
                    {
                        count++;
                    }
                }
            }

            return count > 1;
        }

        /// <summary>
        /// Handling pawn position 
        /// </summary>
        /// <param name="p">Selected pawn</param>
        private void HandleNewPawnPosition(Pawn p)
        {
            Field curField = p.CurrentField;
            FieldType fType = curField.Type;

            // Pawn finished the game 
            if (p.PawnFinished)
            {
                var plr = GetPawnOwner(p);
                plr.PawnsEscaped++;
                var btn = FindControlFromPawn(p);
                btn.Hide();

                if (plr.PawnsEscaped == PlayerConstants.PawnsPerPlayer)
                {
                    foreach (Control C in this.Controls)
                    {
                        C.Hide();
                    }

                    //this.lblWinner.Text = $"{plr.Name} wins!";
                    //this.lblWinner.ForeColor = ColorConstants.Colors[(int)plr.Color];
                    //this.lblWinner.Show();
                    return;
                }

                this.GameState = GameStateType.ChangePlayerTurn;
                return;
            }

            // Hit the other player 
            if (curField.HasPawn)
            {
                this.RemovePawnsFromField(curField, p);
            }

            curField.HasPawn = true;

            this.GameState = GameStateType.ChangePlayerTurn;
        }

        /// <summary>
        /// Select the pawn owner 
        /// </summary>
        /// <param name="p">selected pawn</param>
        /// <returns></returns>
        private Player GetPawnOwner(Pawn p)
        {
            for (int i = 0; i < this.playerCount; i++)
            {
                for (int j = 0; j < PlayerConstants.PawnsPerPlayer; j++)
                {
                    if (this.players[i].Pawns[j].Equals(p))
                        return this.players[i];
                }
            }

            return null;
        }
    }
}
