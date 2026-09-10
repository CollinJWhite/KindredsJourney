using Microsoft.Xna.Framework;
using KindredsJourney.Players;

namespace KindredsJourney.Commands
{
    public class TeleportCommand : ICommand
    {
        private readonly IPlayer player;
        private Vector2 destination;

        public TeleportCommand(IPlayer player)
        {
            this.player = player;
        }

        public void SetDestination(Point destination)
        {
            this.destination = new Vector2(destination.X, destination.Y);
        }

        public void Execute()
        {
            player.Position = destination;
        }
    }
}