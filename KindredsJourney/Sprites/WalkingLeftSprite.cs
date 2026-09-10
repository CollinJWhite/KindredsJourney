using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KindredsJourney.Sprites
{
    public class WalkingLeftSprite : KindredSpriteState
    {
        public WalkingLeftSprite(Texture2D texture)
            : base(texture, new Rectangle(89, 0, 16, 16))
        {
        }
    }
}