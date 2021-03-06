﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Ultimatefightingleague.components;
namespace Ultimatefightingleague
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Fighter main;
        MoveSystem ms = new MoveSystem();
        DamageSystem ds = new DamageSystem();
        Fighter dummy;

        AnimationDrawSystem ads = new AnimationDrawSystem();
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

            // TODO: use this.Content to load your game content here
            Movement m = new Movement();
            animlinker al1 = new animlinker();
            Animation test = new Animation();
          
            test.framenumber = 2;
            test.framesize = new Vector2(90, 90);
            test.offset = 0;
            test.row = 1;
            test.rowamount = 2;
            test.tex = Content.Load<Texture2D>("Plankton_Pepe");
            al1.links.Add(Fighter.State.walking, test);

            main = new Fighter();
            ms.add(main);
            main.Components.Add(al1);


            dummy = new Fighter();
            ms.add(dummy);

            Movement fads = (Movement)dummy.getcomponent(typeof(Movement));
            fads.x = -10;
            ds.fighters.Add(dummy);
            ds.fighters.Add(main);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            // TODO: Add your update logic here

            ms.update_mo();

            /*
            if(main.mystate == Fighter.State.punching)
            {
                //insert code to see if other fighter is in range, if they are :
               var damage_system.damage(other fighter, getpowerforstate(main.mystate));

            }
            */
          animlinker temp = (animlinker)main.getcomponent(typeof(animlinker));
            if (temp.links[Fighter.State.walking].currentframe < 2)
            {
                temp.links[Fighter.State.walking].currentframe += 1;
            }
            else
            {
                temp.links[Fighter.State.walking].currentframe = 0;
            }

            ds.update();
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            ads.drawfighter(spriteBatch, main);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
