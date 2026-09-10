using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using KindredsJourney.Commands;

namespace KindredsJourney.Controllers
{
    public class KeyboardController : IController
    {
        private readonly Dictionary<Keys, ICommand> controllerMappings;
        private readonly ICommand idleCommand;

        private bool moved;

        public KeyboardController(ICommand idleCommand)
        {
            controllerMappings = new Dictionary<Keys, ICommand>();
            this.idleCommand = idleCommand;
        }

        public void RegisterCommand(Keys key, ICommand command)
        {
            controllerMappings.Add(key, command);
        }

        public void Update()
        {
            moved = false;
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();

            foreach (Keys key in pressedKeys)
            {
                if (controllerMappings.TryGetValue(key, out ICommand command))
                {
                    command.Execute();
                    moved = true;
                }
            }
            if (!moved)
            {
                idleCommand.Execute();
            }
        }
    }

}
