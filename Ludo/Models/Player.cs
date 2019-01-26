namespace Ludo.Models
{
    using Ludo.Enumerations;
    using Ludo.Constants;
    using System.Collections.Generic;
    public class Player
    {
        // Player name like Daniel 
        public string Name { get; set; }
        // The count of the available pawns at home 
        public int PawnsAtHome { get; set; }
        // The count of the escaped pawns 
        public int PawnsEscaped { get; set; }
        // The count of the steps left 
        public int StepsLeft { get; set; }
        // a list of pawns for each player 
        public List<Pawn> Pawns{ get; set; }
        // Home fields 
        public Home Home { get; set; }
        // The color for the spesific player 
        public ColorType Color { get; set; }
        // Select pawn number 
        public int SelectedPawn { get; set; }

        /// <summary>
        /// Initializing the player 
        /// </summary>
        /// <param name="name">Player name </param>
        /// <param name="color">Player color picked</param>
        public Player(string name, ColorType color)
        {
            this.Name = name;
            this.Color = color;
            this.PawnsAtHome = PlayerConstants.InitPawnsAtHome;
            this.PawnsEscaped = PlayerConstants.InitPawnsEscaped;
            this.StepsLeft = 0;
            // Create the Home Fields 
            this.Home = new Home(color);
            this.Pawns = new List<Pawn>();

            for (int i = 0; i < PlayerConstants.PawnsPerPlayer; i++)
                Pawns.Add(new Pawn(Color, i));
        }
    }
}
