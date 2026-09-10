using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KindredsJourney.Players
{
    public interface IPlayer
    {
        Vector2 Position { get; set; }
        PlayerDirection Direction { get; }

        void SetDirection(PlayerDirection direction);
        void Move(Vector2 delta);
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
