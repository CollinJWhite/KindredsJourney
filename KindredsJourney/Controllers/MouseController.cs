using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using KindredsJourney.Commands;

namespace KindredsJourney.Controllers
{
    public class MouseController : IController
    {
        private readonly TeleportCommand teleportCommand;

        public MouseController(TeleportCommand teleportCommand)
        {
            this.teleportCommand = teleportCommand;
        }

        public void Update()
        {
            MouseState mouseState = Mouse.GetState();

            if (mouseState.LeftButton == ButtonState.Pressed)
            {
                teleportCommand.SetDestination(mouseState.Position);
                teleportCommand.Execute();
            }
        }
    }

}
