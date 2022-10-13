using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    class GameAccount
    {
        public GameAccount(string UserName)
        {
            this.UserName = UserName;
        }
        public string UserName { get; set; }
        private int currentRating = 100;
        public int CurrentRating { get; private set; }
        public int GamesCount { get; private set; }

        public void WinGame(string opponentName, int rating)
        {
            if (rating < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Помилка, рейтинг на який грають не може бути від'ємним");
            } else
            {
                CurrentRating = currentRating + rating;
                currentRating = CurrentRating;
                //Console.WriteLine("рейтинг после победы: " + currentRating);
                GamesCount++;
            }
        }

        public void LoseGame(string opponentName, int rating)
        {
            if (rating < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Помилка, рейтинг на який грають не може бути від'ємним");
            } else
            {
                CurrentRating = currentRating - rating;
                if (CurrentRating < 1)
                {
                    CurrentRating = 1;
                }
                currentRating = CurrentRating;

                //Console.WriteLine("рейтинг после проигрыша: " + currentRating);
                GamesCount++;
            }
        }

        public void GetStats(List<GameHistory> playerHistoryOfGames)
        {
            Console.WriteLine("Статистика гравця " + playerHistoryOfGames[0].PlayerName + ":");
            Console.WriteLine("Кiлькiсть зиграних iгор: " + GamesCount);
            foreach (GameHistory game in playerHistoryOfGames)
            {
                game.PrintInfo();
            }
            Console.WriteLine("Поточний рейтинг: " + CurrentRating);
            Console.WriteLine();
        }

    }
}
