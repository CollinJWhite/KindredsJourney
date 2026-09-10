using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KindredsJourney.Sprites
{
    public class IdleSprite : KindredSpriteState
    {
        public IdleSprite(Texture2D texture)
            : base(texture, new Rectangle(180, 0, 13, 16))
        {
        }
    }
}