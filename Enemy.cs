using System.Numerics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame2
{
    public class Enemy : BaseClass
    {

        public Enemy(Texture2D texture, Microsoft.Xna.Framework.Vector2 position)
            :base(texture, position)
        {
            color = Color.Black;
        }

        public override void Update()
        {
           
        }
    }
}