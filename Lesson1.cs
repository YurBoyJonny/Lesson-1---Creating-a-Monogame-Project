using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Lesson_1
{
    public class Lesson1 : Game
    {

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D ballTexture;
        Rectangle ballRect;

        Texture2D backgroundTexture;
        Rectangle backgroundRect;

        Texture2D walterwhiteTexture;
        Rectangle walterwhiteRect;

        Texture2D dinoTexture;

        Texture2D basketballTexture;
        Rectangle basketballRect;

        int i;
        Random generator = new Random();

        public Lesson1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 500; // Sets the height of the window
            _graphics.ApplyChanges(); // Applies the new dimensions
            this.Window.Title = "My First Monogame Project";

            backgroundRect = new Rectangle(0, 0, 800, 500);

            walterwhiteRect = new Rectangle(600, 300, 200, 300);

            basketballRect = new Rectangle(100, 100, 100, 100);

            ballRect = new Rectangle(100, 100, 100, 100);

            base.Initialize();
        }
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            ballTexture = Content.Load<Texture2D>("Balls");
            ballRect = new Rectangle(generator.Next(1,600), generator.Next(1,500), 100, 100);

            backgroundTexture = Content.Load<Texture2D>("breakingbadbackground");
            backgroundRect = new Rectangle(0, 0, 800, 500);

            walterwhiteTexture = Content.Load<Texture2D>("walterwhite");
            walterwhiteRect = new Rectangle(600, 300, 200, 300);

            dinoTexture = Content.Load<Texture2D>("dino");

            basketballTexture = Content.Load<Texture2D>("basketball");
            basketballRect = new Rectangle(generator.Next(1,600), generator.Next(1,500), 100, 100);

        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkRed);
            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(backgroundTexture,backgroundRect, Color.White);

            for (i = 0; i <= 800; i += 100)
            {
                _spriteBatch.Draw(dinoTexture, new Vector2(i,50), Color.White);
            }

            _spriteBatch.Draw(walterwhiteTexture, walterwhiteRect, Color.White);

            _spriteBatch.Draw(ballTexture, ballRect, Color.White);

            _spriteBatch.Draw(basketballTexture, basketballRect, Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}