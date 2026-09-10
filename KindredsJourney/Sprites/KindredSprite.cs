using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using KindredsJourney.Players;
using System.Collections.Generic;

namespace KindredsJourney.Sprites
{
    public class KindredSprite : ISprite
    {
        private readonly Dictionary<PlayerDirection, ISprite> sprites;
        private ISprite currentSprite;

        public KindredSprite(Texture2D texture)
        {
            sprites = new Dictionary<PlayerDirection, ISprite>
            {
                { PlayerDirection.Idle, new IdleSprite(texture) },
                { PlayerDirection.Up, new WalkingUpSprite(texture) },
                { PlayerDirection.Down, new WalkingDownSprite(texture) },
                { PlayerDirection.Left, new WalkingLeftSprite(texture) },
                { PlayerDirection.Right, new WalkingRightSprite(texture) }
            };

            currentSprite = sprites[PlayerDirection.Idle];
        }

        public int Width => currentSprite.Width;
        public int Height => currentSprite.Height;

        public void Update(PlayerDirection direction)
        {
            currentSprite = sprites[direction];
            currentSprite.Update(direction);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            currentSprite.Draw(spriteBatch, position);
        }
    }
}
