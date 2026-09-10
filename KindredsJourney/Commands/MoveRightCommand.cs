using Microsoft.Xna.Framework;
using KindredsJourney.Players;

namespace KindredsJourney.Commands
{
    public class MoveRightCommand : ICommand
    {
        private readonly IPlayer player;

        public MoveRightCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.SetDirection(PlayerDirection.Right);
            player.Move(new Vector2(2, 0));
        }
    }
}