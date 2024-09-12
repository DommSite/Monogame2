using System.Numerics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.MediaFoundation;


namespace Monogame2
{
    public class Swiper : Enemy
    {
        
        public Swiper(Texture2D texture, Microsoft.Xna.Framework.Vector2 position)
            :base(texture, position)
        {
            color = Color.Black;
        }

        public override void Update()
        {
            MouseState ms = Mouse.GetState();

            if(position.Y==0){
                position.Y++;
            }
            if(position.Y+100==480){
                position.Y--;
            }    
           
        }

        



    }
}