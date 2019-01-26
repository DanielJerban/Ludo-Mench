namespace Ludo.Models
{
    using Ludo.Enumerations;
    using Ludo.Constants;
    using Ludo.Models;
    using Ludo.Models.Game;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using Contracts;
    using System.Threading.Tasks;

    
    /*
      We use delegate as a reference to other methods 
      so we can call several methods from several classes 
      in a special class method 
     */
    public delegate void PawnChangedPos(object sender, EventArgs e);

    public class Pawn : IPawn
    {
        // Delegate reference as an event 
        public event PawnChangedPos OnPawnChange;
        // The current field that a pawn is on it 
        private Field currentField;
        // The type of the Pawn
        public ColorType Color { get; private set; }
        // Panw name + color name 
        public string PawnName { get; private set; }
        // Pawn position 
        public int PawnPos { get; set; }
        // Is pawn in the finish position or not 
        public bool PawnIsInFinish { get; set; }
        // The pawn finished the game 
        public bool PawnFinished { get; private set; }
        // Is the pawn at home or not 
        public bool IsAtHome { get; set; }

        /// <summary>
        /// Initializing pawn 
        /// </summary>
        /// <param name="color">The color of the pawn</param>
        /// <param name="number">The number of the pawn</param>
        public Pawn(ColorType color, int number)
        {
            this.Color = color;
            this.PawnName = $"{PawnConstants.PawnNames[(int)color]}{number}";
            this.IsAtHome = true;
            this.PawnIsInFinish = false;
            // Pawn Starting Position for each color 
            this.PawnPos = PlaygroundConstants.PlayerStartPos[(int)color];
        }

        public Field CurrentField
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
                
                // Changing the current position 
                this.TriggerChange();
            }
        }

        // Change the current position 
        private void TriggerChange()
        {
            // Both are the same 
            OnPawnChange?.Invoke(this, EventArgs.Empty);
            //if (OnPawnChange != null)
            //{
            //    OnPawnChange(this, EventArgs.Empty);
            //}
        }

        /// <summary>
        /// Move Pawn 
        /// </summary>
        /// <param name="playground">List of playground fields</param>
        /// <param name="finish">List of finish fiields</param>
        /// <param name="steps">The Dice number</param>
        public async void Move(IList<Field> playground, IList<Field> finish, int steps)
        {
            // The pawn is at home 
            if (this.IsAtHome)
            {
                #region Dice = 6 needed 

                // If the dice number is equal to 6
                // Set the pawn in the home field 
                // So the player can start moving throw the playground 
                if (steps == DiceConstants.MaxStandart)
                {
                    // The pawn gets out of the home field 
                    this.IsAtHome = false;
                    // Setting the current position to starting point 
                    this.PawnPos = PlaygroundConstants.PlayerStartPos[(int)this.Color];
                    // The current field that the pawn is on it 
                    this.CurrentField = playground[this.PawnPos];
                    // Plays the spesific sound 
                    AudioPlayer.PlayStepSound();
                }

                // The user still needs to wait 
                return;

                #endregion
            }
            // The pawn ain't at home so it can move 
            else
            {
                #region MoveForward
                // Pawn moves forward 
                for (int i = 0; i < steps; i++)
                {
                    AudioPlayer.PlayStepSound();

                    // The pawn is in the EntryToFinish Field
                    if (this.PawnPos == PlaygroundConstants.PlayerEntryToFinish[(int)this.Color])
                    {
                        // After one move the pawn goes in the finish fields 
                        this.PawnIsInFinish = true;
                        // The pawn is in the first field of the finish line 
                        this.PawnPos = 0;
                        this.CurrentField = finish[this.PawnPos];

                        // Delays a moment to clearly that the pawn is moving 
                        await Task.Delay(PawnConstants.DisplayDelay);
                        continue;
                    }

                    // Increase the pawn position 
                    this.PawnPos++;

                    // The pawn is in finish 
                    if (this.PawnIsInFinish)
                    {
                        // The pawn has finished the game and 
                        // it is out of the finish fields 
                        if(this.PawnPos >= PlaygroundConstants.FinishSize)
                        {
                            this.PawnFinished = true;
                            return;
                        }

                        // Otherwise the pawn moves forward for one field 
                        this.CurrentField = finish[this.PawnPos];
                    }
                    else
                    {
                        // The pawn moves over the red  starting field
                        if (this.PawnPos >= PlaygroundConstants.PlaygroundSize && this.Color != ColorType.Red)
                        {
                            this.PawnPos = 0;
                        }

                        // Setting the current field position 
                        this.CurrentField = playground[this.PawnPos];
                    }

                    // Delays a moment to clearly that the pawn is moving 
                    await Task.Delay(PawnConstants.DisplayDelay);
                }
                #endregion
            }
        }
    }
}
