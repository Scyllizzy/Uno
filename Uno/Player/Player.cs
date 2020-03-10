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
    /// Represents an individual user.
    /// </summary>
    public class Player
    {
        private double winLossRatio;

        /// <summary>
        /// Primary key / identity column.
        /// </summary>
        [Key]
        public int PlayerID { get; set; }

        /// <summary>
        /// The legal first name of the user.
        /// </summary>
        [StringLength(15, MinimumLength = 1)]
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// The legal first name of the user.
        /// </summary>
        [StringLength(15, MinimumLength = 1)]
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// A valid email address with an @ symbol and . something.
        /// Ex. (a@a.a)
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// Number of games the user has won.
        /// </summary>
        public int Win { get; set; }

        /// <summary>
        /// Number of games the user has lost forfeit counts as loss.
        /// </summary>
        public int Loss { get; set; }

        /// <summary>
        /// A unique UserName 1 - 15.
        /// </summary>
        [StringLength(15, MinimumLength = 5)]
        [Required]
        public string UserName { get; set; }

        public double WinLossRatio()
        {
            winLossRatio = Win / Loss;
            return winLossRatio;
        }


        public override string ToString()
        {
            return $"{UserName} {winLossRatio}";
        }
    }
}
