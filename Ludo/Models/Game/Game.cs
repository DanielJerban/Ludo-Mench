using Ludo.Enumerations;
using Ludo.Extensions;
using Ludo.Models;
using Ludo.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ludo.Models.Dices;
using Ludo.Interfaces;

namespace Ludo.Models.Game
{
    public partial class Game : Form
    {
        // Each game has a list of player 
        private List<Player> players;
        // Current player pawns 
        private Player currentPlayer;
        // List of playground fields 
        private IList<Field> playground;
        //private IList<PictureBox> tokens;
        private int turn;
        private int playerCount;
        public event GameStateChanged OnStateChanged;
        private GameStateType gameState;
        private IDice diceStandart;
        private Random rnd;
        private int curPlayerInitialThrows;
        private IList<Field> redFinish;
        private IList<Field> greenFinish;
        private IList<Field> yellowFinish;
        private IList<Field> blueFinish;

        /// <summary>
        /// Initializing game 
        /// </summary>
        /// <param name="dict">Dictionary of color and string</param>
        public Game(Dictionary<ColorType, string> dict)
        {
            InitializeComponent();

            //lblWinner.Hide();
            // Create a list of players 
            players = new List<Player>();
            // Create the playground 
            playground = Playground.GetPlayground();
            //tokens = this.InitTokenPictureboxes();
            OnStateChanged += GameStateHub;
            diceStandart = new DiceStandart();
            rnd = new Random();
            lblStandart.Text = "";
            curPlayerInitialThrows = 0;

            redFinish = Playground.GetFinish(ColorType.Red);
            greenFinish = Playground.GetFinish(ColorType.Green);
            yellowFinish = Playground.GetFinish(ColorType.Yellow);
            blueFinish = Playground.GetFinish(ColorType.Blue);

            // Creating the players 
            for (int i = 0; i < PlayerConstants.MaxPlayers; i++)
            {
                // Cascating int to ColorType 
                if (dict.ContainsKey((ColorType)i))
                {
                    players.Add(new Player(dict[(ColorType)i], (ColorType)i));
                }
                else
                {
                    this.HideUnusedPawns((ColorType)i);
                }
            }

            this.playerCount = players.Count;
            this.turn = 0;
            // Display Pawn position 
            this.players.ForEach(x =>
            {
                x.Pawns.ForEach(y => y.OnPawnChange += DisplayNewPawnPos);
            });
            
            this.players.ForEach(x => x.Pawns.ForEach(f => f.CurrentField = x.Home.FindEmptyHomeField()));

            this.GameState = GameStateType.InitPlayerTurn;
        }

        //private void HandlePawnClick(object sender, EventArgs e)
        //{

        //}

        //private void HandleDiceClick(object sender, EventArgs e)
        //{

        //}
    }
}
