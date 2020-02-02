using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class PlayerDb
    {
        /// <summary>
        /// Returns a list of all the players sorted by PlayerID in ascending order.
        /// </summary>
        public static List<Player> GetAllPlayers()
        {
            using (PlayerContext context = new PlayerContext())
            {
                // LINQ (Language Integrated Query) Method Syntax
                List<Player> players = context.Players
                                       .OrderBy(p => p.PlayerID)
                                       .ToList();
                return players;
            }
        }

        /// <summary>
        /// Adds a player to the DB and returns the player.
        /// </summary>
        public static Player Add(Player p)
        {
            using (PlayerContext context = new PlayerContext())
            {
                context.Players.Add(p);  // Preparing insert query
                context.SaveChanges();  // Execute insert query against DB
                return p;    // Return the player with the PlayerID set
            }
        }

        /// <summary>
        /// Deletes a player from the DB.
        /// </summary>
        public static void Delete(Player p)
        {
            using (var context = new PlayerContext())
            {
                context.Players.Attach(p);
                context.Entry(p).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates all player data (except for PK) and returns the updated player.
        /// </summary>
        public static Player Update(Player p)
        {
            using (PlayerContext context = new PlayerContext())
            {
                context.Players.Attach(p);
                context.Entry(p).State = EntityState.Modified;
                context.SaveChanges();
                return p;
            }
        }
    }
}
