using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using KindredsJourney.Controllers;
using KindredsJourney.Commands;
using KindredsJourney.Players;
using KindredsJourney.Sprites;

namespace KindredsJourney
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private IPlayer player;
        private KeyboardController keyboard;
        private MouseController mouse;

        // The SpriteFont Description used to draw text.
        private SpriteFont font;
        // Defines the position to draw the text at.
        private Vector2 textPosition;
        // Defines the origin used when drawing the score text.
        private Vector2 textOrigin;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            IsMouseVisible = true;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            font = Content.Load<SpriteFont>("fonts/File");

            textPosition = new Vector2(Window.ClientBounds.Width * 0.3f, Window.ClientBounds.Height * 0.6f);
            textOrigin = new Vector2(0, 0);

            // Player sprite
            Texture2D playerTexture = Content.Load<Texture2D>("images/mario");
            ISprite playerSprite = new KindredSprite(playerTexture);

            // Player instance (requires starting position!)
            Vector2 startingPosition = new Vector2(
                (Window.ClientBounds.Width - playerSprite.Width) * 0.5f,
                (Window.ClientBounds.Height - playerSprite.Height) * 0.5f);
            player = new Player(playerSprite, startingPosition);

            // Controller
            keyboard = new KeyboardController(new IdleCommand(player));

            keyboard.RegisterCommand(Keys.W, new MoveUpCommand(player));
            keyboard.RegisterCommand(Keys.S, new MoveDownCommand(player));
            keyboard.RegisterCommand(Keys.A, new MoveLeftCommand(player));
            keyboard.RegisterCommand(Keys.D, new MoveRightCommand(player));

            mouse = new MouseController(new TeleportCommand(player));
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            keyboard.Update();
            mouse.Update();
            player.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.BlueViolet);

            spriteBatch.Begin();

            player.Draw(spriteBatch);
            spriteBatch.DrawString(font, "Credits\nProgram Made By: Collin White\nSprites from Carmen Canvas", textPosition, Color.White, 0.0f, textOrigin, 1.0f, SpriteEffects.None, 0.0f);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
