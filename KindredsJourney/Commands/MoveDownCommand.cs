using Microsoft.Xna.Framework;
using KindredsJourney.Players;

namespace KindredsJourney.Commands
{
    public class MoveDownCommand : ICommand
    {
        private readonly IPlayer player;

        public MoveDownCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.SetDirection(PlayerDirection.Down);
            player.Move(new Vector2(0, 2));
        }
    }
}