using Microsoft.Xna.Framework;
using KindredsJourney.Players;

namespace KindredsJourney.Commands
{
    public class MoveUpCommand : ICommand
    {
        private readonly IPlayer player;

        public MoveUpCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.SetDirection(PlayerDirection.Up);
            player.Move(new Vector2(0, -2));
        }
    }
}