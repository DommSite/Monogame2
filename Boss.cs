using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.MediaFoundation;


namespace Monogame2
{
    public class Boss : Enemy
    {
        float directionx = 1;
        float directiony = 1; 
        public Boss(Texture2D texture, Vector2 position)
            :base(texture, position)
        {
            color = Color.Black;
        }

        public override void Update()
        {
            MouseState ms = Mouse.GetState();
            Vector2 mousePos = -ms.Position.ToVector2();
            if(mousePos.X<=400){
                position.X = 150;
            }
            if(mousePos.X>=400){
                position.X = 350;
            }
            if(mousePos.Y<=240){
                position.Y = 70;
            }
            if(mousePos.Y>=240){
                position.Y = 310;
            }
            /*position.X = -(mousePos.X/2+400);
            position.Y = -(mousePos.Y/2+240);*/
        }

        



    }
}