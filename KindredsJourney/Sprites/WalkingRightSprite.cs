using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KindredsJourney.Sprites
{
    public class WalkingRightSprite : KindredSpriteState
    {
        public WalkingRightSprite(Texture2D texture)
            : base(texture, new Rectangle(300, 0, 16, 16))
        {
        }
    }
}