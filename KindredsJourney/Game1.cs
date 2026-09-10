using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace KindredsJourney;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Texture2D _logo;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
        _logo = Content.Load<Texture2D>("images/KindredLogo");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // Begin the sprite batch to prepare for rendering.
        _spriteBatch.Begin();

        // Draw the logo texture
        _spriteBatch.Draw(
            _logo,              // texture
            new Vector2(        // position
                (Window.ClientBounds.Width * 0.5f),
                (Window.ClientBounds.Height * 0.5f)),
            null,               // sourceRectangle
            Color.Green,        // color
            0.0f,               // rotation
            new Vector2(                // origin
                _logo.Width,
                _logo.Height) * 0.5f,    
                0.25f,          // scale
            SpriteEffects.None, // effects
            0.0f                // layerDepth
        );
        // Always end the sprite batch when finished.
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
