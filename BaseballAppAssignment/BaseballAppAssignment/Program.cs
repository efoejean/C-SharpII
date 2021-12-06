using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseballAppAssignment.BaseballEntities db = new BaseballAppAssignment.BaseballEntities();

            //Display the names and batting averages of all players in the Players table in order by the player’s last name descending.          
            ShowPlayers("Names and batting averages of all players", db.Players.OrderByDescending(p => p.LastName));

            //Display the name and average of the players whose first names begin with ‘J’.
            ShowPlayers("Name and average of the players whose first names begin with ‘J’", db.Players.Where(p => p.FirstName.StartsWith("J")));

            // Display the names and batting averages of all players with a batting average between 0.3 and .35.
            ShowPlayers("Names and batting averages of all players with a batting average between 0.3 and 0.35", db.Players
                .Where(p => p.BattingAverage > 0.3m & p.BattingAverage < 0.35m));  

            Console.ReadKey();


            void ShowPlayers(string title, IEnumerable<Player> Players)
            {
                Console.WriteLine("\n" + title);
                Console.WriteLine("First Name     Last Name      BattingAverage");
                Console.WriteLine("------------ -------------    ------");
                foreach (Player a in Players)
                {
                    Console.WriteLine($"{a.FirstName,-15}{a.LastName,-15}{a.BattingAverage,-15}");
                    
                }

                Console.WriteLine();
            }

        }
    }
}
