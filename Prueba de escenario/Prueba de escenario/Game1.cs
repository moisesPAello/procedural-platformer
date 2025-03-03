﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Prueba_de_escenario;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    Texture2D targetSprite;
    Texture2D crosshairsSprite;
    Texture2D backgroundSprite;
    SpriteFont gameFont;

    Vector2 targetPosition = new Vector2(300, 300);
    const int targetRadius = 45;

    MouseState mState;
    bool mReleased = true;
    int score = 0;

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

        // TODO: use this.Content to load your game content here

        targetSprite = Content.Load<Texture2D>("target");
        crosshairsSprite = Content.Load<Texture2D>("crosshairs");
        backgroundSprite = Content.Load<Texture2D>("sky");
        gameFont = Content.Load<SpriteFont>("galleryFont");

    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        mState = Mouse.GetState();
        if(mState.LeftButton == ButtonState.Pressed && mReleased == true)
        {
            float mouseTargetDist = Vector2.Distance(targetPosition, mState.Position.ToVector2());
            if (mouseTargetDist <= targetRadius)
            {
                score++;
                Random rand = new Random();
                targetPosition.X = rand.Next(0 + targetRadius, _graphics.PreferredBackBufferWidth - targetRadius);
                targetPosition.Y = rand.Next(0 + targetRadius, _graphics.PreferredBackBufferHeight - targetRadius);
            }
            mReleased = false;
        }
        if(mState.LeftButton == ButtonState.Released)
        {
            mReleased = true;
        }

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        _spriteBatch.Begin();
        _spriteBatch.Draw(backgroundSprite, new Vector2(0, 0), Color.White);
        _spriteBatch.DrawString(gameFont, "Test Message", new Vector2(100, 100), Color.White);
        _spriteBatch.Draw(targetSprite, new Vector2(targetPosition.X - targetRadius, targetPosition.Y - targetRadius), Color.White);
        _spriteBatch.DrawString(gameFont, score.ToString(), new Vector2(500, 100), Color.White);

        _spriteBatch.End();


        base.Draw(gameTime);
    }
}
