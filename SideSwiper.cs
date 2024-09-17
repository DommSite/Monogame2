using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.MediaFoundation;


namespace Monogame2
{
    public class SideSwiper : Enemy
    {
        float directionx = -1;
        float directiony = -1; 
        public SideSwiper(Texture2D texture, Vector2 position)
            :base(texture, position)
        {
            color = Color.Black;
        }

        public override void Update()
        {
            position.X+=directionx;
            position.Y+=directiony;
            if(position.X==0){
                directionx *= -1;
            }
            
            if(position.X+100==800){
                directionx *= -1;
            }    
            if(position.Y==0){
                directiony *= -1;
            }
            if(position.Y+100==480){
                directiony *= -1;
            }    
           
        }

        



    }
}