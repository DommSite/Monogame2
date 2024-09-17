using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Numerics;

namespace Monogame2
{
    public class CircleGoer : Enemy
    {
        float angle = 1;
        public CircleGoer(Texture2D texture, Microsoft.Xna.Framework.Vector2 position)
            :base(texture, position)
        {
            color = Color.Black;
        }

        public override void Update()
        {
            MouseState ms = Mouse.GetState();
            float radian = angle*(MathF.PI/180);
            position.Y =(float) Math.Sin(radian)*180+190;
            position.X =(float) Math.Cos(radian)*180+350;
            angle++;
            if(angle==361){
                angle = 1;
            }

            
           
        }

        



    }
    
        
}