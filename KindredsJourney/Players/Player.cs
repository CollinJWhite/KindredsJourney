using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using KindredsJourney.Sprites;

namespace KindredsJourney.Players
{
    public class Player : IPlayer
    {
        public Vector2 Position { get; set; }
        public PlayerDirection Direction { get; private set; }
        private ISprite sprite;

        public Player(ISprite sprite, Vector2 startingPosition)
        {
            this.sprite = sprite;
            Position = startingPosition;
            Direction = PlayerDirection.Idle;
        }

        public void SetDirection(PlayerDirection direction)
        {
            Direction = direction;
        }

        public void Move(Vector2 delta)
        {
            Position += delta;
        }

        public void Update()
        {
            sprite.Update(Direction);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Position);
        }
    }
}