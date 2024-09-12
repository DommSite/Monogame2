﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame2;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    Texture2D pixel;
    Player player;
    Enemy enemy;
    Swiper swiper;
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

        entities.Add(player);
        entities.Add(enemy);
        entities.Add(swiper);


        player = new Player(pixel);
        enemy = new Enemy(pixel, new Vector2(400,380));
        swiper = new Swiper(pixel, new Vector2(200, 0));
        entities.Add(player);
        entities.Add(enemy);
        entities.Add(swiper);



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
}
