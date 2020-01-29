using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    /// <summary>
    /// Represents an individual user(person playing uno)
    /// </summary>
    class Player
    {
        private double winLossRatio;

        /// <summary>
        /// Primary key/ identity column
        /// </summary>
        public int PlayerID { get; set; }

        /// <summary>
        /// The legal first name of the user.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The legal first name of the user.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// A valid email address with an @ symbol and . something.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Number of games the user has won.
        /// </summary>
        public int Win { get; set; }

        /// <summary>
        /// Number of games the user has lost forfeit counts as loss
        /// </summary>
        public int Loss { get; set; }

        /// <summary>
        /// The Win/Loss Ratio Win/Loss = WinLossRatio.
        /// </summary>
        public double WinLossRatio 
        { 
            get => winLossRatio;
            set => winLossRatio = Win / Loss;
        }

        /// <summary>
        /// A unique UserName 1 - 15.
        /// </summary>
        public string UserName { get; set; }
    }
}
