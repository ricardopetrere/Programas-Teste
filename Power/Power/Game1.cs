using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace Power
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Bola bola = new Bola();
        Vector2 gravidade = new Vector2(10f);

        //http://www.youtube.com/watch?v=XReSDA0AgUc
        Menu menu = new Menu();
        Sair btnSair = new Sair();
        public static bool saindo = false;
        bool topo = false;
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Bola.Textura = Content.Load<Texture2D>("red_ball");
            Bola.Tela = graphics.GraphicsDevice.Viewport;
            Menu.tela = graphics.GraphicsDevice.Viewport;
            Menu.textura = Content.Load < Texture2D>("lblParabens");
            Sair.textura = Content.Load<Texture2D>("btnSair");
            base.Initialize();

        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            bola.Localizacao = new Vector2((Bola.Tela.Width - Bola.Textura.Width) / 2, (Bola.Tela.Height - Bola.Textura.Height));
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }
        bool loadedmenu = false;
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (bola.Localizacao.Y < 0)
                topo = true;
            if (topo)
            {

                IsMouseVisible = true;
                MouseState mouse = Mouse.GetState();
                if (saindo)
                    this.Exit();
                
                btnSair.Update(mouse);
            }
            else
                bola.Update((float)gameTime.ElapsedGameTime.TotalSeconds);
            base.Update(gameTime);

        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            if (topo)
            {
                menu.Draw(spriteBatch);
                btnSair.Draw(spriteBatch);
                if (!loadedmenu)
                {
                    System.Threading.Thread.Sleep(1000);
                    loadedmenu = true;
                }
            }
            bola.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
