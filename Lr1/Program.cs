// See https://aka.ms/new-console-template for more information
namespace Lr1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameAccount player1 = new GameAccount("Vlad");
            
            GameAccount player2 = new GameAccount("Artem");

            Game game = new Game();
            game.GameImitation(player1, player2, 10);
            game.GameImitation(player1, player2, 20);
            game.GameImitation(player1, player2, 15);
            game.GameImitation(player1, player2, 40);

            player1.GetStats(game.p1History);
            player2.GetStats(game.p2History);

        }


    }
}
