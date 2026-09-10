using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KindredsJourney.Sprites
{
    public class WalkingDownSprite : KindredSpriteState
    {
        public WalkingDownSprite(Texture2D texture)
            : base(texture, new Rectangle(270, 0, 12, 16))
        {
        }
    }
}