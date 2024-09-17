﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame2;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    Texture2D pixel;

    List<BaseClass> entities = new List<BaseClass>();
    
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        pixel = new Texture2D(GraphicsDevice,1,1);
        pixel.SetData(new Color[]{Color.White});

    
        
        /*entities.Add(new Player(pixel));
        entities.Add(new Enemy(pixel, new Vector2(400,380)));*/
        entities.Add(new Swiper(pixel, new Vector2(200, 0)));
        entities.Add(new CircleGoer(pixel, new Vector2(350, 190)));
        entities.Add(new Slicer(pixel, new Vector2(350, 190)));
        entities.Add(new SideSwiper(pixel, new Vector2(350, 190)));
        entities.Add(new Boss(pixel, new Vector2(350, 190)));



        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        foreach(var entity in entities){
            entity.Update();
        }
        RemoveEnemy();
        AddEnemy();
        

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();

        foreach(var entity in entities){
            entity.Draw(_spriteBatch);
        }

        _spriteBatch.End();
        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }

    public void RemoveEnemy(){
        List<BaseClass> temp = new List<BaseClass>();
        Random rand = new Random();
        MouseState ms = Mouse.GetState();
        

        foreach(var enemy in entities){
            if(){
                temp.Add(enemy);

            }

            entities=temp;
        }
    }



    public void AddEnemy(){
        Random rand = new Random();

        if(rand.Next(1,1000)<= 10){
            entities.Add(new Enemy(pixel, new Vector2(rand.Next(0,700),1)));
        }
    }
}
