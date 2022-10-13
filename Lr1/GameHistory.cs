using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    internal class GameHistory
    {
        public GameHistory(string PlayerName, string opponentName, string Status, int rating, string Index)
        {
            this.PlayerName = PlayerName;
            this.OpponentName = opponentName;
            this.Status = Status;
            this.Rating = rating;
            this.Index = Index;
        }

        public string PlayerName { get; private set; }
        public string OpponentName { get; private set; }
        public string Status { get; private set; }
        public int Rating { get; private set; }
        public string Index { get; private set; }

        public void PrintInfo()
        {
            Console.WriteLine(Status + " проти " + OpponentName + " на " + Rating + " рейтинга " + "(iндекс гри: " + Index + ")");
        }

    }
}
