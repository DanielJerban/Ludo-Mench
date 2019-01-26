using Ludo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Models
{
    public abstract class Dice : IDice
    {
        // The minum number that a dice can have
        public int MinNum { get; private set; }
        // The maximum number that a dice can have 
        public int MaxNum { get; private set; }

        /// <summary>
        /// Setting the dice number 
        /// </summary>
        /// <param name="min">Dice Min number</param>
        /// <param name="max">Dice Max number</param>
        public Dice(int min, int max)
        {
            this.MinNum = min;
            this.MaxNum = max;
        }

        // Select a random number between max and min dice number 
        public int Throw(Random rnd)
        {
            return rnd.Next(this.MinNum, this.MaxNum + 1);
        }
    }
}
