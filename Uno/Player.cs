using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    /// <summary>
    /// Represents an individual user(person playing uno)
    /// </summary>
    public class Player
    {
        private double winLossRatio;

        /// <summary>
        /// Primary key/ identity column
        /// </summary>
        [Key]
        public int PlayerID { get; set; }

        /// <summary>
        /// The legal first name of the user.
        /// </summary>
        [Column(TypeName = "varchar(25)")]
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// The legal first name of the user.
        /// </summary>
        [Column(TypeName = "varchar(25)")]
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// A valid email address with an @ symbol and . something.
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
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
        [Column(TypeName ="varchar(15)")]
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// The password for the player's account.
        /// </summary>
        public string Password { get; set; }
    }
}
