using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.MediaFoundation;


namespace Monogame2
{
    public class Swiper : Enemy
    {
        float direction = 1;
        public Swiper(Texture2D texture, Vector2 position)
            :base(texture, position)
        {
            color = Color.Black;
        }

        public override void Update()
        {
            MouseState ms = Mouse.GetState();
            position.Y+=direction;
            if(position.Y==0){
                direction *= -1;
            }
            if(position.Y+100==480){
                direction *= -1;
            }    
           
        }

        



    }
}