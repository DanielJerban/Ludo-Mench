using Ludo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Extensions
{
    public static class HomeExtensions
    {
        /// <summary>
        /// Finds the empty home fields 
        /// </summary>
        /// <param name="home">Home fields</param>
        /// <returns></returns>
        public static Field FindEmptyHomeField(this Home home)
        {
            foreach (var field in home.Fields)
            {
                // Leave the fields that has pawn alone 
                if (field.HasPawn)
                {
                    continue;
                }

                field.HasPawn = true;
                return field;
            }

            return home.Fields[0];
        }
    }
}
