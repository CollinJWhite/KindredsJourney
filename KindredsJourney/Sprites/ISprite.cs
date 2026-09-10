using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using KindredsJourney.Players;

namespace KindredsJourney.Sprites
{
    public interface ISprite
    {
        int Width { get; }
        int Height { get; }
        void Update(PlayerDirection direction);
        void Draw(SpriteBatch spriteBatch, Vector2 position);
    }
}
