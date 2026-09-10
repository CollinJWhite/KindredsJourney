using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KindredsJourney.Sprites
{
    public class WalkingUpSprite : KindredSpriteState
    {
        public WalkingUpSprite(Texture2D texture)
            : base(texture, new Rectangle(120, 0, 12, 16))
        {
        }
    }
}