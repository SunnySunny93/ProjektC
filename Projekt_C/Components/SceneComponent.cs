using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Projekt_C
{
	internal class SceneComponent : DrawableGameComponent
	{
		private SpriteBatch spriteBatch; 	/// Braucht man für jegliche Art von Darstellung
		private Texture2D pixel;			/// Nutzt der SpriteBatch
		private Game1 game;

		public SceneComponent (Game1 game) : base(game)
		{
			this.game = game;
		}

		protected override void LoadContent()
		{
			spriteBatch = new SpriteBatch(GraphicsDevice);
			pixel = new Texture2D(GraphicsDevice, 1, 1);
			pixel.SetData<Color>(new Color[] { Color.White });

			base.LoadContent();
		}

		public override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);

			int width = GraphicsDevice.Viewport.Width - 20;
			int height = GraphicsDevice.Viewport.Height - 20;

			spriteBatch.Begin();

			spriteBatch.Draw(pixel, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, 10), Color.DarkGray);
			spriteBatch.Draw(pixel, new Rectangle(0, GraphicsDevice.Viewport.Height - 10, GraphicsDevice.Viewport.Width, 10), Color.DarkGray);
			spriteBatch.Draw(pixel, new Rectangle(GraphicsDevice.Viewport.Width - 10, 0, 10, GraphicsDevice.Viewport.Height), Color.DarkGray);

			spriteBatch.Draw(pixel, new Rectangle(
				(int)(game.Simulation.BallPosition.X * width) + 10,
				(int)(game.Simulation.BallPosition.Y * height) + 10, 10, 10), Color.White);

			int playerRadius = (int)(game.Simulation.PlayerSize * height) / 2;
			int player = (int)(height * game.Simulation.PlayerPosition) - playerRadius + 10;

			spriteBatch.Draw(pixel, new Rectangle(0, player, 10, playerRadius * 2), Color.DarkGray);

			spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}
