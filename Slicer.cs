using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.MediaFoundation;


namespace Monogame2
{
    public class Slicer : Enemy
    {
        float direction = 1;
        public Slicer(Texture2D texture, Vector2 position)
            :base(texture, position)
        {
            color = Color.Black;
        }

        public override void Update()
        {
            position.X+=direction;
            if(position.X==0){
                direction *= -1;
            }
            if(position.X+100==800){
                direction *= -1;
            }    
           
        }

        



    }
}