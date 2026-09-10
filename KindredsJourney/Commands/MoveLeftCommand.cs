using Microsoft.Xna.Framework;
using KindredsJourney.Players;

namespace KindredsJourney.Commands
{
    public class MoveLeftCommand : ICommand
    {
        private readonly IPlayer player;

        public MoveLeftCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.SetDirection(PlayerDirection.Left);
            player.Move(new Vector2(-2, 0));
        }
    }
}