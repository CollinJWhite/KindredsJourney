using KindredsJourney.Players;

namespace KindredsJourney.Commands
{
    public class IdleCommand : ICommand
    {
        private IPlayer player;

        public IdleCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.SetDirection(PlayerDirection.Idle);
        }
    }
}
