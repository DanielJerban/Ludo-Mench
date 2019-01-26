namespace Ludo.Models
{
    using Ludo.Enumerations;

    public class Field
    {
        // The type of the field
        public FieldType Type { get; set; }
        // The field position in the X side 
        public int XPos { get; set; }
        // The field position in the Y side
        public int YPos { get; set; }
        // Does the field has Pawn or not 
        public bool HasPawn { get; set; }

        /// <summary>
        /// Initializing fields 
        /// </summary>
        /// <param name="type">Field Type </param>
        /// <param name="x">X side position </param>
        /// <param name="y">Y side position </param>
        public Field(FieldType type, int x, int y)
        {
            this.Type = type;
            this.XPos = x;
            this.YPos = y;
            this.HasPawn = false;
        }
    }
}
