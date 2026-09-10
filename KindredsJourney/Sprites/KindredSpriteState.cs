using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using KindredsJourney.Players;

namespace KindredsJourney.Sprites
{
    public abstract class KindredSpriteState : ISprite
    {
        private readonly Texture2D texture;
        private readonly Rectangle sourceRectangle;

        protected KindredSpriteState(Texture2D texture, Rectangle sourceRectangle)
        {
            this.texture = texture;
            this.sourceRectangle = sourceRectangle;
        }

        public int Width => sourceRectangle.Width * 3;
        public int Height => sourceRectangle.Height * 3;

        public void Update(PlayerDirection direction)
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.Draw(texture, position, sourceRectangle, Color.White, 0.0f, Vector2.Zero, 3.0f, SpriteEffects.None, 0.0f);
        }
    }
}