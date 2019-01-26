using Ludo.Enumerations;
using Ludo.Exceptions;
using Ludo.Models;
//using Ludo.Models.About;
using Ludo.Models.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
            
            btnStart.MouseEnter += new EventHandler(btnStart_MouseEnter);
            btnStart.MouseLeave += new EventHandler(btnStart_MouseLeave);
            btnExit.MouseEnter += new EventHandler(btnExit_MouseEnter);
            btnExit.MouseLeave += new EventHandler(btnExit_MouseLeave);
        }


        // Change background image 
        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = Properties.Resources.BtnStart;
        }
        // Change background image 
        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = Properties.Resources.BtnStartGlow;
        }


        // Change background image 
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.BackgroundImage = Properties.Resources.BtnExit;
        }
        // Change background image 
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            this.btnExit.BackgroundImage = Properties.Resources.BtnExitGlow;
        }

        // Starting the Game 
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Init player count 
            int players = 0;
            // Empty name exception 
            bool emptyName = false;
            // List of players pawn
            var list = new List<Player>();
            // A Dictionary of players color and name 
            // Which at the highest count is equal to 4 (4 players)
            var dict = new Dictionary<ColorType, string>();

            // Updating the count of the players
            // Adding their color and name to Dictionary 
            // And at the end adding theme to the list 
            if (plrOneCheck.Checked)
            {
                players++;

                dict.Add(ColorType.Red, plrOneText.Text);
                list.Add(new Player(plrOneText.Text, ColorType.Red));

                // Empty name exception occured 
                if (string.IsNullOrEmpty(plrOneText.Text))
                    emptyName = true;
            }
            if (plrTwoCheck.Checked)
            {
                players++;

                dict.Add(ColorType.Green, plrTwoText.Text);
                list.Add(new Player(plrTwoText.Text, ColorType.Green)); 

                // Empty name exception occured 
                if (string.IsNullOrEmpty(plrTwoText.Text))
                    emptyName = true;
            }
            if (plrThreeCheck.Checked)
            {
                players++;

                dict.Add(ColorType.Yellow, plrThreeText.Text);
                list.Add(new Player(plrThreeText.Text, ColorType.Yellow));

                // Empty name exception occured 
                if (string.IsNullOrEmpty(plrThreeText.Text))
                    emptyName = true;
            }
            if (plrFourCheck.Checked)
            {
                players++;

                dict.Add(ColorType.Blue, plrFourText.Text);
                list.Add(new Player(plrFourText.Text, ColorType.Blue)); 

                // Empty name exception occured 
                if (string.IsNullOrEmpty(plrFourText.Text))
                    emptyName = true;
            }

            // No player choosen or there is only one player 
            if(players < 2)
            {
                try
                {
                    throw new InvalidPlayerCountException("At least two players have to be checked.");
                }
                catch (InvalidPlayerCountException ex)
                {
                    lblWarning.Text = ex.Message;
                    lblWarning.ForeColor = Color.Red;
                }
                
                return;
            }

            // Handling the empty name exception 
            if(emptyName)
            {
                try
                {
                    throw new InvalidNameException("Please, don't leave empty name spaces.");
                }
                catch (InvalidNameException ex)
                {
                    lblWarning.Text = ex.Message;                   
                }
                
                return;
            }

            // An object of the Game class which has a dictionary of the players 
            var game = new Game(dict);
            game.FormBorderStyle = FormBorderStyle.FixedSingle;
            game.Show();
        }

        // Exit click 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
