using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    class Game
    {
        public List<GameHistory> p1History = new List<GameHistory>();
        public List<GameHistory> p2History = new List<GameHistory>();

        

        private static int gameIdSeed = 1;
        private string gameId;

        public void GameImitation (GameAccount p1, GameAccount p2, int rating)
        {
            Random random = new Random();
            int i = random.Next(0, 10);
            gameId = gameIdSeed.ToString();
            if (i <= 4)
            {
                p1.WinGame(p2.UserName, rating);
                p1History.Add(new GameHistory(p1.UserName, p2.UserName, "Перемога", rating, gameId));
                p2.LoseGame(p1.UserName, rating);
                p2History.Add(new GameHistory(p2.UserName, p1.UserName, "Поразка", rating, gameId));
            } else {
                p2.WinGame(p1.UserName, rating);
                p2History.Add(new GameHistory(p2.UserName, p1.UserName, "Перемога", rating, gameId));
                p1.LoseGame(p2.UserName, rating);
                p1History.Add(new GameHistory(p1.UserName, p2.UserName, "Поразка", rating, gameId));
            }
            gameIdSeed++;
        }
        
    }
}
