using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ErstesProjekt
{
	internal class InputComponent : GameComponent
	{
		public Vector2 Direction {
			get;
			private set;
		}

		public InputComponent (Game1 game) : base(game)
		{
		}

		public override void Update (GameTime gameTime)
		{
			GamePadState state = GamePad.GetState (PlayerIndex.One);
			Direction = state.ThumbSticks.Left * new Vector2(1f, -1f);

			base.Update (gameTime);
		}
	}
}

