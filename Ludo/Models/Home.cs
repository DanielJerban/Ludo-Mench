namespace Ludo.Models
{
    using Ludo.Constants;
    using Ludo.Enumerations;
    using System.Collections.Generic;

    public class Home
    {
        // A list of fields for each player home side
        public IList<Field> Fields { get; private set; }
        // The center of the home position on the X side 
        private int originX;
        // The center of the home position on the Y side
        private int originY;

        /// <summary>
        /// Setting the home fields in the right place 
        /// </summary>
        /// <param name="color">The color of the home fields</param>
        public Home(ColorType color)
        {
            // Setting the center position on the X side for a spesifice color 
            this.originX = HomeConstants.HomeOriginX[(int)color];
            // Setting the center position on the Y side for a spesifice color 
            this.originY = HomeConstants.HomeOriginY[(int)color];

            // Creates the list of the home field
            this.Fields = new List<Field>()
            {
                // LEFT side home field 
                new Field(FieldType.HomeField, this.originX - HomeConstants.OffsetFromOrigin, this.originY),
                // RIGHT side home field
                new Field(FieldType.HomeField, this.originX + HomeConstants.OffsetFromOrigin, this.originY),
                // TOP side home field 
                new Field(FieldType.HomeField, this.originX, this.originY - HomeConstants.OffsetFromOrigin),
                // BOTTOM side home field
                new Field(FieldType.HomeField, this.originX, this.originY + HomeConstants.OffsetFromOrigin)
            };
        }
    }
}
